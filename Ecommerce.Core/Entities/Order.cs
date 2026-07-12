using Ecommerce.Core.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Entities
{
    public class Order : BaseEntity
    {
        public Order(Guid idCostumer, DateTime? confirmationDate, DateTime? shippingDate, OrderStatus status, Guid deliveryAddressId, decimal shippingPrice, decimal totalProductsPrice, List<OrderItem> items, List<OrderUpdate> updates)
        {
            IdCostumer = idCostumer;
            ConfirmationDate = confirmationDate;
            ShippingDate = shippingDate;
            Status = status;
            DeliveryAddressId = deliveryAddressId;
            ShippingPrice = shippingPrice;
            TotalProductsPrice = totalProductsPrice;
            Items = items;
            Updates = updates;
        }

        public Guid IdCostumer { get; set; }
        public DateTime? ConfirmationDate { get; set; } //after payment confirmation
        public DateTime? ShippingDate { get; set; }
        public OrderStatus Status { get; set; }
        public Guid DeliveryAddressId { get; set; }
        public CustomerAddress DeliveryAddress { get; set; }
        public decimal ShippingPrice { get; set; }
        public decimal TotalProductsPrice { get; set; }
        public List<OrderItem> Items { get; set; }
        public List<OrderUpdate> Updates { get; set; }
    }
}
