using MyYuGiOhDeck.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyYuGiOhDeck.Domain.Interfaces
{
    public interface IYGOProDeckApiService
    {
        Task<IList<SpellTrapCard>> GetAllSpellCardsAsync();
    }
}
