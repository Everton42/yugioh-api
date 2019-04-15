using System.Collections.Generic;
using System.Threading.Tasks;
using MyYuGiOhDeck.Domain.Entities;
using MyYuGiOhDeck.Domain.Interfaces;

namespace MyYuGiOhDeck.Service.Services
{
    public class MySpellTrapCardsService : BaseService<SpellTrapCard>, IMySpellTrapCardsService
    {
        private new readonly IMySpellTrapCardsRepository _repository;
        public MySpellTrapCardsService(IMySpellTrapCardsRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<List<SpellTrapCard>> GetAllMySpellCardsAsync()
        {
            return await _repository.GetAllMySpellCardsAsync();
        }

        public async Task<List<SpellTrapCard>> GetAllMyTrapCardsAsync()
        {
            return await _repository.GetAllMyTrapCardsAsync();
        }
    }
}
