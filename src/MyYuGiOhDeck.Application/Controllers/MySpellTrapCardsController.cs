using Microsoft.AspNetCore.Mvc;
using MyYuGiOhDeck.Domain.Entities;
using MyYuGiOhDeck.Domain.Interfaces;
using MyYuGiOhDeck.Service.Validation;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyYuGiOhDeck.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/MyCards")]
    [ApiController]
    public class MyCardsController : ControllerBase
    {
        private readonly IMySpellTrapCardsService _service;
        public MyCardsController(IMySpellTrapCardsService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetMySpellCards")]
        public async Task<List<SpellTrapCard>> GetAllMySpellCardsAsync()
        {
            return await _service.GetAllMySpellCardsAsync();
        }

        [HttpGet]
        [Route("GetMyTrapCards")]
        public async Task<List<SpellTrapCard>> GetAllMyTrapCardsAsync()
        {
            return await _service.GetAllMyTrapCardsAsync();
        }
        [HttpGet]
        [Route("GetMySpellTrapCardById")]
        public async Task<SpellTrapCard> GetSpellTrapCardByIdAsync(string id)
        {
            return await _service.GetByIdAsync(id);
        }

        [HttpPost]
        [Route("SaveSpellTrapCard")]
        public async Task<SpellTrapCard> SaveSpellCardAsync(SpellTrapCard obj)
        {
            return await _service.InsertAsync<SpellTrapCardValidator>(obj);
        }

        [HttpDelete]
        [Route("DeleteMySpellTrapCard")]
        public async Task<bool> DeleteMySpellTrapCardAsync(string id)
        {
            return await _service.DeleteAsync(id);
        }
    }
}