using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using OzonEdu.MerchandiseService.Infrastructure.StartupFilters;
using OzonEdu.MerchandiseService.Infrastructure.Filters;

namespace OzonEdu.MerchandiseService.Infrastructure.Extensions
{
    public static class HostBuilderExtensions
    {
        public static IHostBuilder AddInfrastructure(this IHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                services.AddSingleton<IStartupFilter, TerminalStartupFilter>();

                services.AddSingleton<IStartupFilter, SwaggerStartupFilter>();
                services.AddSwaggerGen(config =>
                {
                    config.SwaggerDoc("v1", new OpenApiInfo() {Title = "OzonEdu.MerchandiseService", Version = "v1"});
                });
            });

            return builder;
        }
        
        public static IHostBuilder AddHttp(this IHostBuilder builder)
        {
            builder.ConfigureServices(services =>
            {
                builder.ConfigureServices(services =>
                {
                    services.AddControllers(options => options.Filters.Add<GlobalExceptionFilter>());
                });
            });

            return builder;
        }
        
    }
}