using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Yummy.Application.Features.Booking.Queries;
using Yummy.Application.Features.Booking.Results;
using Yummy.Application.Interfaces.Repositories;

namespace Yummy.Application.Features.Booking.Handlers.Queries
{
    public sealed class GetBookingQueryHandler : IRequestHandler<GetBookingQuery, ICollection<GetBookingQueryResult>>
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetBookingQueryHandler> _logger;

        public GetBookingQueryHandler(IBookingRepository bookingRepository, IMapper mapper, ILogger<GetBookingQueryHandler> logger)
        {
            _bookingRepository = bookingRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<ICollection<GetBookingQueryResult>> Handle(GetBookingQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var values = await _bookingRepository.ListAsync(cancellationToken);
                return _mapper.Map<ICollection<GetBookingQueryResult>>(values);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching bookings");
                throw new Exception("An error occurred while fetching bookings", ex);
            }
        }
    }
}
