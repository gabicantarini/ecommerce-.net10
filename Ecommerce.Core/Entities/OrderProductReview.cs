using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Entities
{
    public class OrderProductReview : BaseEntity
    {
        public OrderProductReview(int idOrderItem, OrderItem orderItem, Guid idCustomer, Customer customer, string title, string description, int score)
        {
            IdOrderItem = idOrderItem;
            OrderItem = orderItem;
            IdCustomer = idCustomer;
            Customer = customer;
            Title = title;
            Description = description;
            Score = score;
        }

        public int IdOrderItem { get; set; }
        public OrderItem OrderItem { get; set; }
        public Guid IdCustomer { get; set; }
        public Customer Customer { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Score { get; set; }
        
    }
}
