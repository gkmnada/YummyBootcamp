using MediatR;
using Yummy.Application.Common.Base;

namespace Yummy.Application.Features.Booking.Commands
{
    public sealed class UpdateBookingCommand : IRequest<BaseResponse>
    {
        public int BookingID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public DateOnly BookingDate { get; set; }
        public TimeOnly BookingTime { get; set; }
        public int PeopleCount { get; set; }
        public string Message { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
