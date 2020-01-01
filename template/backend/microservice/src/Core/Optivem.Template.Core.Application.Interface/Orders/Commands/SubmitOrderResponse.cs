﻿using Optivem.Template.Core.Common.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Template.Core.Application.Orders.Commands
{
    public class SubmitOrderResponse
    {
        public Guid Id { get; set; }

        public OrderStatus Status { get; set; }
    }
}
