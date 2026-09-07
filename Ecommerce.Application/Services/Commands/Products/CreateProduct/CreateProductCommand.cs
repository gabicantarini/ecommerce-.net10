using Ecommerce.Application.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services.Commands.Products.CreateProduct
{
    public class CreateProductCommand // Command class for creating a new product. It came from Entity Product, but we don't need all the properties, so we create a command class with only the properties we need to create a new product.
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Brand { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public Guid IdCategory { get; set; }
    }

}
