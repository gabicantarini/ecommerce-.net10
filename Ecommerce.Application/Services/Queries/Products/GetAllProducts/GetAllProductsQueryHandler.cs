using Ecommerce.Application.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services.Queries.Products.GetAllProducts
{
    public class GetAllProductsQueryHandler
        : IHandler<GetAllProductsQuery, ResultViewModel<List<GetAllProductsItemViewModel>>>
    {

        public Task<ResultViewModel<List<GetAllProductsItemViewModel>>> HandleAsync(GetAllProductsQuery? request)
        {
            throw new NotImplementedException();
        }
    }
}
