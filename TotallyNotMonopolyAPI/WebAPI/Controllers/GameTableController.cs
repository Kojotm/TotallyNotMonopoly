using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class GameTableController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
