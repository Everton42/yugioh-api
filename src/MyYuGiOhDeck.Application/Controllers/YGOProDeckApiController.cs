using Microsoft.AspNetCore.Mvc;
using MyYuGiOhDeck.CrossCutting;
using MyYuGiOhDeck.Domain.Entities;
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
        public YGOProDeckApiController()
        {
            ApiHelper.InitializeClient();
        }
        YGOProDeckApiService service = new YGOProDeckApiService();

        [HttpGet]
        [Route("GetAllCards")]
        public async Task<IList<SpellTrapCard>> GetAllCardsAsync()
        {
             IList<SpellTrapCard> list = await service.GetAllCardsAsync();
                return list;
        }
    }
}