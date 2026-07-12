using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Enums
{
    public enum OrderStatus
    {
        Created, // added to data base but not yet confirmed
        Confirmed, // confirmed by the payment gateway
        Picking, // being prepered for shipment
        Shipped,
        Delivered,
        Cancelled
    }
}
