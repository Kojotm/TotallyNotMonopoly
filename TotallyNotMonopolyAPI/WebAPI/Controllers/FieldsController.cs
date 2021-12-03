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
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            return Ok(fieldService.GetById(id));

        }
    }
}
