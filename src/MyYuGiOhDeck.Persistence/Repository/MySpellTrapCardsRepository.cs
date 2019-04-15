using Microsoft.EntityFrameworkCore;
using MyYuGiOhDeck.Domain.Entities;
using MyYuGiOhDeck.Domain.Interfaces;
using MyYuGiOhDeck.Persistence.Context;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyYuGiOhDeck.Persistence.Repository
{
    public class MySpellTrapCardsRepository : BaseRepository<SpellTrapCard>, IMySpellTrapCardsRepository
    {
        public MySpellTrapCardsRepository(MyYuGiOhDeckDbContext context) : base(context)
        {
        }

        public async Task<List<SpellTrapCard>> GetAllMySpellCardsAsync()
        {
            var listCards = Task.FromResult( await _db.Where(x => 
            x.Type.Contains("Spell Card"))
                .ToListAsync()).Result;
            return listCards;
        }

        public async Task<List<SpellTrapCard>> GetAllMyTrapCardsAsync()
        {
            var listCards = Task.FromResult(await _db.Where(x =>
           x.Type.Contains("Trap Card"))
                .ToListAsync()).Result;
            return listCards;
        }
    }
}
