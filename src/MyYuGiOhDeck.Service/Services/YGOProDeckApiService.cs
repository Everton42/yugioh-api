using MyYuGiOhDeck.Domain.Entities;
using MyYuGiOhDeck.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyYuGiOhDeck.Service.Services
{
    public class YGOProDeckApiService : IYGOProDeckApiService
    {
        private IYGOProDeckApiClient _client;
        public YGOProDeckApiService(IYGOProDeckApiClient client)
        {
            _client = client;
        }
        public Task<IList<SpellTrapCard>> GetAllSpellCardsAsync()
        {
            return _client.GetAllSpellCardsAsync();
        }
    }
}
