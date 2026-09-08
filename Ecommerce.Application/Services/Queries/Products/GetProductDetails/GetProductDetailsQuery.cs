using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services.Queries.Products.GetProductDetails;
public class GetProductDetailsQuery
{
    public GetProductDetailsQuery(Guid idProduct)
    {
        IdProduct = idProduct;
    }

    public Guid IdProduct { get; set; }
}
