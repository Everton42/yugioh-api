using Microsoft.AspNetCore.Mvc;
using MyYuGiOhDeck.Domain.Entities;
using MyYuGiOhDeck.Domain.Interfaces;
using MyYuGiOhDeck.Domain.ValueObject;
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
        [Route("SpellCards")]
        [ProducesResponseType(typeof(SpellTrapCard), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAllSpellCardsAsync()
        {
            return Ok(await _service.GetAllSpellCardsAsync());
        }
    }
}