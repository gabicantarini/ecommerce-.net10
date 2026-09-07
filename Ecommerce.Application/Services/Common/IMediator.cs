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
        public Mediator(IServiceScopeFactory factory)
        {
            _factory = factory;
        }

        public async Task<TResponse> DispatchAsync<TRequest, TResponse>(TRequest request)
        {
            var scope = _factory.CreateScope();
            var handler = scope.ServiceProvider.GetRequiredService<IHandler<TRequest, TResponse>>();
            return await handler.HandlerAsync(request);
        }
    }

    public interface IHandler<TRequest, TResponse>
    {
        Task<TResponse> HandlerAsync(TRequest request);
    }

} 
