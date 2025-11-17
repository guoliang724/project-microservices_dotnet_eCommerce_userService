using eCommerce.Core.RepositoryContracts;
using eCommerce.Infrastructure.DbContext;
using eCommerce.Infrastructure.Repository;
using Microsoft.Extensions.DependencyInjection;


namespace eCommerce.Infrastructure
{
    public static class DependecyInjection
    {
        // extension method to add infrastructure services
        public static IServiceCollection AddInfrastructure(this IServiceCollection services) {
            // including data access, caching and other low-level components

            services.AddTransient<IUserRepository, UserRepository>();

            services.AddTransient<DapperDbContext>();

            return services;
        }
    }
}
