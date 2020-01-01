﻿using Optivem.Framework.Core.Application;

namespace Optivem.Template.Core.Application.Customers.Commands
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}