using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TestTemplate2.Application.Pipelines;

namespace TestTemplate2.Application
{
    public static class ServiceCollectionExtensions
    {
        public static void AddTestTemplate2ApplicationHandlers(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ServiceCollectionExtensions).Assembly);
            services.AddPipelines();

            services.AddAutoMapper(typeof(ServiceCollectionExtensions).Assembly);
        }
    }
}
