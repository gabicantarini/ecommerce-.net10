namespace Ecommerce.Core.Entities
{
    public class ProductImage : BaseEntity
    {
        public ProductImage(string identifier, string path, bool isVisible)
        {
            Identifier = identifier;
            Path = path;
            IsVisible = isVisible;
        }

        public string Identifier { get; set; }
        public string Path { get; set; }
        public bool IsVisible { get; set; }
    }
}
