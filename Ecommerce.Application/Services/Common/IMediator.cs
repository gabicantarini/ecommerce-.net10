

namespace Ecommerce.Application.Services.Common;

    public interface IMediator
    {
        Task<TResponse> DispatchAsync<TRequest, TResponse>(TRequest request); //DispatchAsync method to handle requests and return responses. It has tha same functionality as the sender in the Mediator.
}



