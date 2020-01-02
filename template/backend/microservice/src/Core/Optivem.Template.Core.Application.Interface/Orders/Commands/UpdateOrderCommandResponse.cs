﻿using Optivem.Template.Core.Common.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Optivem.Template.Core.Application.Orders.Commands
{
    public class UpdateOrderCommandResponse
    {
        public Guid Id { get; set; }

        public Guid CustomerId { get; set; }

        public OrderStatus Status { get; set; }

        public List<UpdateOrderItemCommandResponse> OrderItems { get; set; }
    }

    public class UpdateOrderItemCommandResponse
    {
        public Guid Id { get; set; }

        public Guid ProductId { get; set; }

        public decimal Quantity { get; set; }

        public OrderItemStatus Status { get; set; }
    }
}