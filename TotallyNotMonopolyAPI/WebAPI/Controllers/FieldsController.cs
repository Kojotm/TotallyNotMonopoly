using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Model.Cards;
using Persistence;
using Services;

namespace WebAPI.Controllers
{
    public class FieldsController : Controller
    {
        readonly FieldService fieldService = new();

        // GET: Fields
        public async Task<ActionResult> Index()
        {
            return Ok(fieldService.GetAll());
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
