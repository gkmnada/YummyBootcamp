using FluentValidation;
using Yummy.Application.Features.Booking.Commands;

namespace Yummy.Application.Features.Booking.Validators
{
    public class CreateBookingValidator : AbstractValidator<CreateBookingCommand>
    {
        public CreateBookingValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required")
                .MinimumLength(2).WithMessage("Name must not be less than 2 characters")
                .MaximumLength(50).WithMessage("Name must not be more than 50 characters");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required")
                .EmailAddress().WithMessage("Email is not valid");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Phone is required");
            RuleFor(x => x.BookingDate).NotEmpty().WithMessage("Booking date is required");
            RuleFor(x => x.BookingTime).NotEmpty().WithMessage("Booking time is required");
            RuleFor(x => x.PeopleCount).NotEmpty().WithMessage("People count is required");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Message is required")
                .MaximumLength(250).WithMessage("Message must not be more than 250 characters");
        }
    }
}
