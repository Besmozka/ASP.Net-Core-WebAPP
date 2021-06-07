using FluentValidation;
using Timesheets.Infrastructure.Constants;
using Timesheets.Models.Dto;

namespace Timesheets.Infrastructure.Validation
{
    public class CreateUserValidator : AbstractValidator<CreateUserRequest>
    {
        private int minPasswordLength = 6;
        public CreateUserValidator()
        {
            RuleFor(x => x.Username)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.Password)
                .MinimumLength(minPasswordLength)
                .NotNull()
                .NotEmpty();
            RuleFor(x => x.Role)
                .Matches(UserRolesContants.Admin,UserRolesContants.Client,UserRolesContants.User);
        }
    }
}
