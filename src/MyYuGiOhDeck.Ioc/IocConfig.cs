using Microsoft.Extensions.DependencyInjection;
using MyYuGiOhDeck.CrossCutting;
using MyYuGiOhDeck.Domain.Interfaces;
using MyYuGiOhDeck.Service.Services;
using System;

namespace MyYuGiOhDeck.Ioc
{
    public static class IocConfig
    {
        public static void Configure(IServiceCollection services)
        {
            ConfigureService(services);
            ConfigureCrossCutting(services);
        }

        private static void ConfigureService(IServiceCollection services)
        {
            services.AddScoped<IYGOProDeckApiService, YGOProDeckApiService>();
        }

        private static void ConfigureCrossCutting(IServiceCollection services)
        {
            services.AddScoped<IYGOProDeckApiClient, YGOProDeckApiClient>();
        }
    }
}
