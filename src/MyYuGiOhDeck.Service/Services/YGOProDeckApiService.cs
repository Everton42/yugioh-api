using System.Collections.Generic;
using System.Threading.Tasks;
using MyYuGiOhDeck.CrossCutting;
using MyYuGiOhDeck.Domain.Entities;
using MyYuGiOhDeck.Domain.Interfaces;

namespace MyYuGiOhDeck.Service.Services
{
    public class YGOProDeckApiService : IYGOProDeckApiService
    {
        private IYGOProDeckApiClient _client;
        public YGOProDeckApiService(IYGOProDeckApiClient client)
        {
            _client = client;
        }
        public Task<IList<SpellTrapCard>> GetAllCardsAsync()
        {
            return _client.GetAllSpellTrapCardAsync();
        }
    }
}
