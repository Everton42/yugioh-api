using System.Collections.Generic;
using System.Threading.Tasks;
using MyYuGiOhDeck.CrossCutting;
using MyYuGiOhDeck.Domain.Entities;
using MyYuGiOhDeck.Domain.Interfaces;

namespace MyYuGiOhDeck.Service.Services
{
    public class YGOProDeckApiService : IYGOProDeckApiService
    {
        YGOProDeckApiClient client = new YGOProDeckApiClient();
        public Task<IList<SpellTrapCard>> GetAllCardsAsync()
        {
            return client.GetAllSpellTrapCardAsync();
        }
    }
}
