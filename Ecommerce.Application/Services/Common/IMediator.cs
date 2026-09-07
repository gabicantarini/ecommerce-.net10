using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services.Common
{
    public interface IMediator
    {
        Task<TResponse> DispatchAsync<TRequest, TResponse>(TRequest request);
    }

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
            var handler = scope.ServiceProvider.GetRequiredService<IHandler<TRequest, TResponse>>(); //for each handler, we will create a new scope to resolve the dependencies
            return await handler.HandleAsync(request); //call the handler to handle the request
        }
    }

    public interface IHandler<TRequest, TResponse> //generic interface for each handler to implement
    {
        Task<TResponse> HandleAsync(TRequest? request); //each handler will implement this method to handle the request and return the response
    }

} 
