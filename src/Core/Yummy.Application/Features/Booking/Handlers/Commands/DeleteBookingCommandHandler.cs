using MediatR;
using Microsoft.Extensions.Logging;
using Yummy.Application.Common.Base;
using Yummy.Application.Features.Booking.Commands;
using Yummy.Application.Interfaces.Repositories;

namespace Yummy.Application.Features.Booking.Handlers.Commands
{
    public class DeleteBookingCommandHandler : IRequestHandler<DeleteBookingCommand, BaseResponse>
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DeleteBookingCommandHandler> _logger;

        public DeleteBookingCommandHandler(IBookingRepository bookingRepository, IUnitOfWork unitOfWork, ILogger<DeleteBookingCommandHandler> logger)
        {
            _bookingRepository = bookingRepository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<BaseResponse> Handle(DeleteBookingCommand request, CancellationToken cancellationToken)
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

                await _bookingRepository.DeleteAsync(values);
                await _unitOfWork.SaveChangesAsync(cancellationToken);

                return new BaseResponse
                {
                    Data = values,
                    Message = "Booking deleted successfully",
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while deleting the booking");
                throw new Exception("An error occurred while deleting the booking", ex);
            }
        }
    }
}
