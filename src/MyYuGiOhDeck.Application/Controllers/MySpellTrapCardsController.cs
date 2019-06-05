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
        [Route("SpellCard")]
        [ProducesResponseType(typeof(SpellTrapCard), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAllMySpellCardsAsync()
        {
            return Ok(await _service.GetAllMySpellCardsAsync());
        }

        [HttpGet]
        [Route("TrapCard")]
        [ProducesResponseType(typeof(SpellTrapCard), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetAllMyTrapCardsAsync()
        {
            return Ok(await _service.GetAllMyTrapCardsAsync());
        }
        [HttpGet]
        [Route("SpellOrTrapCard/{id}")]
        [ProducesResponseType(typeof(SpellTrapCard), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> GetSpellTrapCardByIdAsync([FromRoute]string id)
        {
            var obj = await _service.GetByIdAsync(id);
            if (obj == null)
                return NotFound();

            return Ok(obj);
        }

        [HttpPost]
        [Route("SpellOrTrapCard")]
        [ProducesResponseType(typeof(SpellTrapCard), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public async Task<IActionResult> SaveSpellCardAsync([FromBody] SpellTrapCard input)
        {
            var obj = await _service.InsertAsync<SpellTrapCardValidator>(input);
            return Created(nameof(SpellTrapCard), obj);
        }

        [HttpDelete]
        [Route("SpellOrTrapCard/{id}")]
        [ProducesResponseType(typeof(SpellTrapCard), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(409)]
        public async Task<IActionResult> DeleteMySpellTrapCardAsync([FromRoute] string id)
        {
            var objDeleted = await _service.DeleteAsync(id);
            if (objDeleted == false)
                return NotFound();
            return Ok();
        }
    }
}