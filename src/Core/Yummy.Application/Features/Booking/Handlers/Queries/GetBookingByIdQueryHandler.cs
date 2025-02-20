using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Yummy.Application.Features.Booking.Queries;
using Yummy.Application.Features.Booking.Results;
using Yummy.Application.Interfaces.Repositories;

namespace Yummy.Application.Features.Booking.Handlers.Queries
{
    public class GetBookingByIdQueryHandler : IRequestHandler<GetBookingByIdQuery, GetBookingByIdQueryResult>
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetBookingByIdQueryHandler> _logger;

        public GetBookingByIdQueryHandler(IBookingRepository bookingRepository, IMapper mapper, ILogger<GetBookingByIdQueryHandler> logger)
        {
            _bookingRepository = bookingRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<GetBookingByIdQueryResult> Handle(GetBookingByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var values = await _bookingRepository.GetByIdAsync(request.BookingID, cancellationToken);
                return _mapper.Map<GetBookingByIdQueryResult>(values);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while fetching the booking by ID");
                throw new Exception("An error occurred while fetching the booking by ID", ex);
            }
        }
    }
}
