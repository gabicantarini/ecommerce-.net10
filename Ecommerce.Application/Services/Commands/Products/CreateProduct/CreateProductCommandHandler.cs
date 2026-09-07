using Ecommerce.Application.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services.Commands.Products.CreateProduct
{
    public class CreateProductCommandHandler
        : IHandler<CreateProductCommand, Guid>
    {
        public Task<Guid> HandleAsync(CreateProductCommand? request) //have important entities to create a product, but we need to implement the logic to handle the command and return the product ID
        {
            throw new NotImplementedException();
        }
    }
}
