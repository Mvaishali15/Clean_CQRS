using Microsoft.Extensions.DependencyInjection;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using StudentAPI.Application.Common.Interfaces.Persistence;
using StudentAPI.Infrastructure.Presistence;
using StudentAPI.Infrastructure.DbContext;

namespace StudentAPI.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, ConfigurationManager configuration)
        {
            services
                .AddContext(configuration)
                .AddPersistence();
            return services;
        }

        public static IServiceCollection AddPersistence(
           this IServiceCollection services)
        {
            services.AddScoped<ITStudentRepository, TStudentRepository>();
            return services;
        }

        public static IServiceCollection AddContext(
           this IServiceCollection services, ConfigurationManager configuration)
        {
            var DapperSettings = new DapperSettings();
            configuration.Bind(DapperSettings.SectionName, DapperSettings);
            services.AddSingleton(Options.Create(DapperSettings));
            services.AddSingleton<DapperContext>();

            return services;
        }
    }
}
