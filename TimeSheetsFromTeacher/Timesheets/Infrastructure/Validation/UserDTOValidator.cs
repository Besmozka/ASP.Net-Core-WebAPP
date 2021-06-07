using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Infrastructure.Constants;
using Timesheets.Models.Dto;

namespace Timesheets.Infrastructure.Validation
{
    public class UserDTOValidator : AbstractValidator<UserDTO>
    {
        public UserDTOValidator()
        {
            RuleFor(x => x.Id)
                .NotNull()
                .WithErrorCode("E-UDTO-1");
            RuleFor(x => x.Username)
                .NotEmpty()
                .WithErrorCode("E-UDTO-2");
            RuleFor(x => x.Role)
                .Must(x => x == UserRolesContants.Admin || x == UserRolesContants.Client || x == UserRolesContants.User)
                .WithErrorCode("E-UDTO-3");
        }
    }
}
