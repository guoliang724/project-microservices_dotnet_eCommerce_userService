using Microsoft.Extensions.DependencyInjection;


namespace eCommerce.Infrastructure
{
    public static class DependecyInjection
    {
        // extension method to add infrastructure services
        public static IServiceCollection AddInfrastructure(this IServiceCollection services) {


            return services;
        }
    }
}
