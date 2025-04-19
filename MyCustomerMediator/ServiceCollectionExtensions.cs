using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomerMediator
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddMyMediator(this IServiceCollection services,
            params Assembly[] assemblies)
        {
            services.AddScoped<Mediator>();
            var handlerInterfaceType = typeof(IRequestHandler<,>);

            var handlers = assemblies.SelectMany(assembly => assembly.GetTypes())
                .Where(t => !t.IsAbstract && !t.IsInterface)
                .SelectMany(t => t.GetInterfaces()
                .Where(i => i.IsGenericType && i.GetGenericTypeDefinition() == handlerInterfaceType),
                (t, i) => new { HandlerType = t, InterfaceType = i });

            foreach (var hanlder in handlers)
            {
                services.AddScoped(hanlder.InterfaceType, hanlder.HandlerType);
            }
            return services;
        }
    }
}
