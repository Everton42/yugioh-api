using Microsoft.AspNetCore.Mvc;
using MyYuGiOhDeck.Domain.Entities;
using MyYuGiOhDeck.Service.Services;
using MyYuGiOhDeck.Service.Validation;
using System;

namespace MyYuGiOhDeck.Application.Controllers
{
    [Produces("application/json")]
    [Route("api/SpellTrapCard")]
    [ApiController]
    public class SpellTrapCardController : ControllerBase
    {
        private BaseService<SpellTrapCard> service = new BaseService<SpellTrapCard>();

    }
}