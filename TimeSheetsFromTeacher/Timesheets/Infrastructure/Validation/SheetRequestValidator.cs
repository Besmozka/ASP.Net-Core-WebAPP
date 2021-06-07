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
                .WithMessage(ValidationMessages.SheetAmount)
                .WithErrorCode("E-SR-1");
            RuleFor(x => x.Date)
                .NotEmpty()
                .WithErrorCode("E-SR-2");
            RuleFor(x => x.EmployeeId)
                .NotEmpty()
                .WithErrorCode("E-SR-2");
        }
    }
}