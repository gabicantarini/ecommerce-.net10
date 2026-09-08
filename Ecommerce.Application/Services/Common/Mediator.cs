using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services.Common
{
    public class Mediator : IMediator
    {
        readonly IServiceScopeFactory _factory;
        public Mediator(IServiceScopeFactory factory) //inject the IServiceScopeFactory to create a new scope for each request
        {
            _factory = factory;
        }

        public async Task<TResponse> DispatchAsync<TRequest, TResponse>(TRequest request)
        {
            var scope = _factory.CreateScope(); //create a new scope for each request to resolve the dependencies
            var handler = scope.ServiceProvider.GetRequiredService<IHandler<TRequest, TResponse>>(); //for each handler, we will create a new scope to resolve the dependencies. Class IHandler treats the request and returns the response. The handler is resolved from the service provider using the GetRequiredService method, which will throw an exception if the handler is not registered in the DI container.
            return await handler.HandleAsync(request); //call the handler to handle the request
        }
    }
}
