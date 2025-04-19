using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomerMediator
{
    public class Mediator(IServiceProvider _serviceProvider)
    {

        //public async Task<TResponse> Send<TRequest, TResponse>(TRequest request, CancellationToken cancellationToken = default) where TRequest : IRequest<TResponse>
        //{
        //    var handler = _serviceProvider.GetService(typeof(IRequestHandler<TRequest, TResponse>)) as IRequestHandler<TRequest, TResponse>;
        //    if (handler == null)
        //    {
        //        throw new InvalidOperationException($"Handler not found for request type {typeof(TRequest).Name}");
        //    }
        //    return await handler.Handle(request, cancellationToken);
        //}

        public async Task<TResponse> Send<TResponse>(IRequest<TResponse> request, CancellationToken cancellationToken = default)
        {
            var handlerType=typeof(IRequestHandler<,>).MakeGenericType(request.GetType(),typeof(TResponse));
            dynamic handler =_serviceProvider.GetService(handlerType);
            if (handler == null)
                throw new InvalidOperationException($"Handler for {request.GetType().Name} not found");

            return await handler.Handle((dynamic)request, cancellationToken);
        }
    }
}
