using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services.Commands.Orders
{
    public class CreateOrderCommand
    {
        public Guid IdCustomer { get; set; }
        public List<CreateOrderCommandItem> Items { get; set; } = new List<CreateOrderCommandItem>(); // or []
        public Guid DeliveryAddressId { get; set; }
    }
}
