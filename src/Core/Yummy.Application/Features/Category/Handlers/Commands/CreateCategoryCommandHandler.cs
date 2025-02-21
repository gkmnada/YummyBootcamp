﻿using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Yummy.Application.Common.Base;
using Yummy.Application.Features.Category.Commands;
using Yummy.Application.Features.Category.Validators;
using Yummy.Application.Interfaces.Repositories;

namespace Yummy.Application.Features.Category.Handlers.Commands
{
    public sealed class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, BaseResponse>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<CreateCategoryCommandHandler> _logger;
        private readonly CreateCategoryValidator _validator;

        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork, IMapper mapper, ILogger<CreateCategoryCommandHandler> logger, CreateCategoryValidator validator)
        {
            _categoryRepository = categoryRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
            _validator = validator;
        }

        public async Task<BaseResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var validationResult = await _validator.ValidateAsync(request, cancellationToken);

                if (!validationResult.IsValid)
                {
                    var errors = validationResult.Errors.Select(e => e.ErrorMessage).ToList();

                    return new BaseResponse
                    {
                        IsSuccess = false,
                        Message = "Validation failed",
                        Errors = errors
                    };
                }

                var category = _mapper.Map<Domain.Entities.Category>(request);

                await _categoryRepository.CreateAsync(category);
                await _unitOfWork.SaveChangesAsync(cancellationToken);

                return new BaseResponse
                {
                    Data = category,
                    Message = "Category created successfully",
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while creating the category");
                throw new Exception("An error occurred while creating the category", ex);
            }
        }
    }
}
