using Microsoft.AspNetCore.Mvc;
using MyYuGiOhDeck.Domain.Entities;
using MyYuGiOhDeck.Domain.Interfaces;
using MyYuGiOhDeck.Domain.ValueObject;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyYuGiOhDeck.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/")]
    [ApiController]
    public class YGOProDeckApiController : ControllerBase
    {
        private readonly IYGOProDeckApiService _service;
        public YGOProDeckApiController(IYGOProDeckApiService service)
        {
            ApiHelper.InitializeClient();
            _service = service;
        }

        [HttpGet]
        [Route("GetAllSpellCards")]
        public async Task<IList<SpellTrapCard>> GetAllSpellCardsAsync()
        {
            IList<SpellTrapCard> list = await _service.GetAllSpellCardsAsync();
            return list;
        }
    }
}