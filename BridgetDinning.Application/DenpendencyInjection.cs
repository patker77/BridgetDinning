using BridgetDinning.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BridgetDinning.Application
{
    public static class DenpendencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService,AuthenticationService>();
            return services;
        }
    }
}