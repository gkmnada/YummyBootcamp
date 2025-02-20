using MediatR;
using Yummy.Application.Common.Base;

namespace Yummy.Application.Features.Booking.Commands
{
    public class DeleteBookingCommand : IRequest<BaseResponse>
    {
        public int BookingID { get; set; }

        public DeleteBookingCommand(int id)
        {
            BookingID = id;
        }
    }
}
