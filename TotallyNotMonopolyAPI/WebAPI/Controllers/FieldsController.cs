using Microsoft.AspNetCore.Mvc;
using Services;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class FieldsController : Controller
    {
        private readonly IFieldService fieldService;

        public FieldsController(IFieldService fieldService)
        {
            this.fieldService = fieldService;
        }

        // GET: Fields
        [HttpGet]
        public async Task<ActionResult> GetFields()
        {
            return Ok(await fieldService.GetAll());
        }

        // GET: Fields/Details/5
        [HttpGet("details/{id}")]
        public async Task<ActionResult> Details(int id)
        {
            var details = await fieldService.GetById(id);

            if (details == null)
            {
                return NotFound();
            }
            return Ok(details);
        }
    }
}
