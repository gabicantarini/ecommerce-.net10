namespace Ecommerce.Core.Entities
{
    public class ProductCategory : BaseEntity 
    {
        public ProductCategory(string title, string subcategory) 
        {
            Title = title;
            Subcategory = subcategory;
            Products = [];
        }

        public string Title { get; set; }
        public string Subcategory { get; set; }
        public List<Product> Products { get; set; }
    }
}
