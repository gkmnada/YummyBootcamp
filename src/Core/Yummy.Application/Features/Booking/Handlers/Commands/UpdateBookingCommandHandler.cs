using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Yummy.Application.Common.Base;
using Yummy.Application.Features.Booking.Commands;
using Yummy.Application.Features.Booking.Validators;
using Yummy.Application.Interfaces.Repositories;

namespace Yummy.Application.Features.Booking.Handlers.Commands
{
    public class UpdateBookingCommandHandler : IRequestHandler<UpdateBookingCommand, BaseResponse>
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpdateBookingCommandHandler> _logger;
        private readonly UpdateBookingValidator _validator;

        public UpdateBookingCommandHandler(IBookingRepository bookingRepository, IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpdateBookingCommandHandler> logger, UpdateBookingValidator validator)
        {
            _bookingRepository = bookingRepository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
            _validator = validator;
        }

        public async Task<BaseResponse> Handle(UpdateBookingCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var values = await _bookingRepository.GetByIdAsync(request.BookingID, cancellationToken);

                if (values == null)
                {
                    return new BaseResponse
                    {
                        IsSuccess = false,
                        Message = "Booking not found"
                    };
                }

                var validationResult = await _validator.ValidateAsync(request);

                if (!validationResult.IsValid)
                {
                    var errors = validationResult.Errors.Select(x => x.ErrorMessage).ToList();

                    return new BaseResponse
                    {
                        IsSuccess = false,
                        Message = "Validation failed",
                        Errors = errors
                    };
                }

                _mapper.Map(request, values);

                await _bookingRepository.UpdateAsync(values);
                await _unitOfWork.SaveChangesAsync(cancellationToken);

                return new BaseResponse
                {
                    Data = values,
                    Message = "Booking updated successfully",
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while updating the booking");
                throw new Exception("An error occurred while updating the booking", ex);
            }
        }
    }
}
