﻿using FluentValidation;
using Atomiv.Infrastructure.FluentValidation;
using Atomiv.Template.Core.Application.Queries.Customers;

namespace Atomiv.Template.Infrastructure.Queries.Validation.Customers
{
    public class ViewCustomerQueryValidator : BaseValidator<ViewCustomerQuery>
    {
        public ViewCustomerQueryValidator()
        {
            RuleFor(e => e.Id)
                .NotEmpty()
                .WithErrorCode(ValidationErrorCodes.NotFound);
        }
    }
}
