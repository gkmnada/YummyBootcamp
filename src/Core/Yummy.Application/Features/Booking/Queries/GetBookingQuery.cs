using MediatR;
using Yummy.Application.Features.Booking.Results;

namespace Yummy.Application.Features.Booking.Queries
{
    public sealed class GetBookingQuery : IRequest<ICollection<GetBookingQueryResult>>
    {
    }
}
