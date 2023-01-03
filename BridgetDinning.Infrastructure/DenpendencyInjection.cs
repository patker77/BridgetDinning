using BridgetDinning.Application.Common.Interfaces.Authentication;
using BridgetDinning.Infrastructure.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BridgetDinning.Infrastructure
{
    public static class DenpendencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<IJwtTokenGenerator,JwtTokenGenerator>();
            return services;
        }
    }
}