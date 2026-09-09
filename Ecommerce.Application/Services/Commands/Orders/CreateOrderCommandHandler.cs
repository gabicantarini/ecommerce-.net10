using Ecommerce.Application.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services.Commands.Orders
{
    internal class CreateOrderCommandHandler
        : IHandler<CreateOrderCommand, ResultViewModel<Guid>>
    {
        public Task<ResultViewModel<Guid>> HandleAsync(CreateOrderCommand? request)
        {
            throw new NotImplementedException();
        }
    }
}
