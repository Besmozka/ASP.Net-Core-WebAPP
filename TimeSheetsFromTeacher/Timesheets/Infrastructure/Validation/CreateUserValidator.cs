﻿using FluentValidation;
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
                .NotEmpty()
                .WithErrorCode("E-U-1");
            RuleFor(x => x.Password)
                .MinimumLength(minPasswordLength)
                .NotEmpty()
                .WithErrorCode("E-U-2");
            RuleFor(x => x.Role)
                .Must(x => x == UserRolesContants.Admin || x == UserRolesContants.Client || x == UserRolesContants.User)
                .WithErrorCode("E-U-3");
        }
    }
}
