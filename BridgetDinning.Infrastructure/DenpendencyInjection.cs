using BridgetDinning.Application.Services.Authentication;
using Microsoft.Extensions.DependencyInjection;

namespace BridgetDinning.Infrastructure
{
    public static class DenpendencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            return services;
        }
    }
}