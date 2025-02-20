using MediatR;
using Microsoft.AspNetCore.Mvc;
using Yummy.Application.Features.Booking.Commands;
using Yummy.Application.Features.Booking.Queries;

namespace Yummy.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("CreateBooking")]
        public async Task<IActionResult> CreateBooking(CreateBookingCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpGet("ListBookings")]
        public async Task<IActionResult> ListBookings()
        {
            var query = new GetBookingQuery();
            var response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookingById(int id)
        {
            var query = new GetBookingByIdQuery(id);
            var response = await _mediator.Send(query);
            return Ok(response);
        }

        [HttpPut("UpdateBooking")]
        public async Task<IActionResult> UpdateBooking(UpdateBookingCommand command)
        {
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBooking(int id)
        {
            var command = new DeleteBookingCommand(id);
            var response = await _mediator.Send(command);
            return Ok(response);
        }
    }
}
