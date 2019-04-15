using Microsoft.Extensions.DependencyInjection;
using MyYuGiOhDeck.CrossCutting;
using MyYuGiOhDeck.Domain.Interfaces;
using MyYuGiOhDeck.Persistence.Repository;
using MyYuGiOhDeck.Service.Services;

namespace MyYuGiOhDeck.Ioc
{
    public static class IocConfig
    {
        public static void Configure(IServiceCollection services)
        {
            ConfigureService(services);
            ConfigureRepository(services);
            ConfigureCrossCutting(services);
        }

        private static void ConfigureService(IServiceCollection services)
        {
            services.AddScoped<IYGOProDeckApiService, YGOProDeckApiService>();
            services.AddScoped<IMySpellTrapCardsService, MySpellTrapCardsService>();
        }

        private static void ConfigureCrossCutting(IServiceCollection services)
        {
            services.AddScoped<IYGOProDeckApiClient, YGOProDeckApiClient>();
        }

        private static void ConfigureRepository(IServiceCollection services)
        {
            services.AddScoped<IMySpellTrapCardsRepository, MySpellTrapCardsRepository>();
        }
    }
}
