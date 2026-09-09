using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services.Commands.Orders
{
    public class CreateOrderCommandItem
    {
        public Guid IdProduct { get; set; }
        public int Quantity { get; set; }
    }
}
