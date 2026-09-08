using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Application.Services.Common
{
    public interface IHandler<TRequest, TResponse> //generic interface for each handler to implement - We simulate the IHandler with 1 Tipe parameter for the request(entrance) and 1 Tipe parameter for the response(output)
    {
        Task<TResponse> HandleAsync(TRequest? request); //each handler will implement this method to handle the request and return the response
    }
}
