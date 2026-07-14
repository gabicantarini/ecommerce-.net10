using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Core.Entities
{
    public class OrderProductReview : BaseEntity
    {
        public OrderProductReview(int idOrderItem, int idCustomer, string title, string description, int score)
        {
            IdOrderItem = idOrderItem;
            IdCustomer = idCustomer;
            Title = title;
            Description = description;
            Score = score;
        }

        public int IdOrderItem { get; set; }
        public int IdCustomer { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Score { get; set; }
        
    }
}
