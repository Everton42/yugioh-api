using MyYuGiOhDeck.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyYuGiOhDeck.Domain.Interfaces
{
    public interface IMySpellTrapCardsService : IService<SpellTrapCard>
    {
        Task<List<SpellTrapCard>> GetAllMySpellCardsAsync();
        Task<List<SpellTrapCard>> GetAllMyTrapCardsAsync();
    }
}
