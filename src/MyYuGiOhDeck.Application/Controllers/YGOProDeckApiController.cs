using Microsoft.AspNetCore.Mvc;
using MyYuGiOhDeck.CrossCutting;
using MyYuGiOhDeck.Domain.Entities;
using MyYuGiOhDeck.Domain.Interfaces;
using MyYuGiOhDeck.Service.Services;
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
        [Route("GetAllCards")]
        public async Task<IList<SpellTrapCard>> GetAllCardsAsync()
        {
             IList<SpellTrapCard> list = await _service.GetAllCardsAsync();
                return list;
        }
    }
}