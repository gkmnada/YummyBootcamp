using MediatR;
using Yummy.Application.Features.Booking.Results;

namespace Yummy.Application.Features.Booking.Queries
{
    public sealed class GetBookingByIdQuery : IRequest<GetBookingByIdQueryResult>
    {
        public int BookingID { get; set; }

        public GetBookingByIdQuery(int id)
        {
            BookingID = id;
        }
    }
}
