using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Ecommerce.Infrastructure.Persistence;

namespace Ecommerce.Infrastructure
{
    public static class InfrastructureModule // static extends the IServiceCollection interface to add infrastructure services to the dependency injection container
    {
        // this class is responsible only to register the infrastructure services to the dependency injection container

        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddDbContext<EcommerceDbContext>(options =>
                options.UseInMemoryDatabase("EcommerceDb"));
            // Register infrastructure services here
            return services;
        }
    }
}

