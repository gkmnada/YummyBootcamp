using FluentValidation;
using Yummy.Application.Features.Category.Commands;

namespace Yummy.Application.Features.Category.Validators
{
    public sealed class CreateCategoryValidator : AbstractValidator<CreateCategoryCommand>
    {
        public CreateCategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required")
                .MinimumLength(3).WithMessage("Name must not be less than 3 characters")
                .MaximumLength(50).WithMessage("Name must not be more than 50 characters");
        }
    }
}
