using Microsoft.AspNetCore.Mvc;
using Services;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CardsController : Controller
    {
        private readonly ICardService cardService;

        public CardsController(ICardService cardService)
        {
            this.cardService = cardService;
        }

        [HttpGet("fortune")]
        public async Task<ActionResult> GetRandomFortuneCard()
        {
            var randomFortuneCard = cardService.GetRandomFortuneCard();

            if (randomFortuneCard == null)
            {
                return NotFound();
            }
            return Ok(randomFortuneCard);
        }

        [HttpGet("chance")]
        public async Task<ActionResult> GetRandomChanceCard()
        {
            var randomChanceCard = cardService.GetRandomChanceCard();

            if (randomChanceCard == null)
            {
                return NotFound();
            }
            return Ok(randomChanceCard);
        }
    }
}
