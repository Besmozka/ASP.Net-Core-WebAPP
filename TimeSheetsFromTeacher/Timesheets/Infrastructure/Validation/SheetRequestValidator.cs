using FluentValidation;
using Timesheets.Infrastructure.Constants;
using Timesheets.Models.Dto;

namespace Timesheets.Infrastructure.Validation
{
    public class SheetRequestValidator: AbstractValidator<SheetRequest>
    {
        public SheetRequestValidator()
        {
            RuleFor(x => x.Amount)
                .InclusiveBetween(1, 8)
                .WithMessage(ValidationMessages.SheetAmount);
            RuleFor(x => x.Date)
                .NotNull();
            RuleFor(x => x.EmployeeId)
                .NotNull();
        }
    }
}