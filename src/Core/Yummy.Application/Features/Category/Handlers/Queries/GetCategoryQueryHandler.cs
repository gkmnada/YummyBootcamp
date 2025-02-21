using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Yummy.Application.Features.Category.Queries;
using Yummy.Application.Features.Category.Results;
using Yummy.Application.Interfaces.Repositories;

namespace Yummy.Application.Features.Category.Handlers.Queries
{
    public sealed class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, ICollection<GetCategoryQueryResult>>
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetCategoryQueryHandler> _logger;

        public GetCategoryQueryHandler(ICategoryRepository categoryRepository, IMapper mapper, ILogger<GetCategoryQueryHandler> logger)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ICollection<GetCategoryQueryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var values = await _categoryRepository.ListAsync(cancellationToken);
                return _mapper.Map<ICollection<GetCategoryQueryResult>>(values);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching the categories");
                throw new Exception("An error occurred while fetching the categories", ex);
            }
        }
    }
}
