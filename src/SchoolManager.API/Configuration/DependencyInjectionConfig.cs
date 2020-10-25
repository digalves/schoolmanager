using Core.Business.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using SchoolManager.Business.Interfaces;
using SchoolManager.Business.Notifications;
using SchoolManager.Business.Services;
using SchoolManager.Data.Repositories;

namespace DevIO.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<IEscolaRepository, EscolaRepository>();
            services.AddScoped<ITurmaRepository, TurmaRepository>();

            services.AddScoped<IEscolaService, EscolaService>();
            services.AddScoped<ITurmaService, TurmaService>();

            services.AddScoped<INotificador, Notificador>();

            return services;
        }
    }
}