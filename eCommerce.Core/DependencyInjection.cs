using eCommerce.Core.ServiceContracts;
using eCommerce.Core.Services;
using eCommerce.Core.Validators;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;


namespace eCommerce.Core
{
    public static class DependecyInjection
    {
        // extension method to add infrastructure services
        public static IServiceCollection AddCore(this IServiceCollection services)
        {
            // including data access, caching and other low-level components

            services.AddTransient<IUserService, UserService>();

            services.AddValidatorsFromAssemblyContaining<LoginRequestValidator>();

            return services;
        }
    }
}
