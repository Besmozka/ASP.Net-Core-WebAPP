using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Timesheets.Infrastructure.Constants;
using Timesheets.Models.Dto;

namespace Timesheets.Infrastructure.Validation
{
    public class InvoiceRequestValidator : AbstractValidator<InvoiceRequest>
    {
        public InvoiceRequestValidator()
        {
            RuleFor(x => x.DateEnd)
                .GreaterThan(x => x.DateStart)
                .WithMessage(ValidationMessages.InvoiceDate)
                .WithErrorCode("E-IR-1");
            RuleFor(x => x.ContractId)
                .NotNull()
                .WithErrorCode("E-IR-2");
        }
    }
}
