namespace Ecommerce.Core.Entities
{
    public class OrderItem : BaseEntity
    {
        public OrderItem(Guid idOrder, Guid idProduct, int quantity, decimal price)
        {
            IdOrder = idOrder;
            IdProduct = idProduct;
            Quantity = quantity;
            Price = price;
        }

        public Guid IdOrder { get; set; }
        public Guid IdProduct { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    } 
}
