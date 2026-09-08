using Ecommerce.Application.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services.Queries.Products.GetProductDetails
{
    public class GetProductDetailsQueryHandler
        : IHandler<GetProductDetailsQuery, ResultViewModel<ProductDetailsViewModel>>
    {
    }
}
