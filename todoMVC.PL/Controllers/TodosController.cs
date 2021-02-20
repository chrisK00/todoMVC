using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todoMVC.DL;

namespace todoMVC.PL.Controllers
{
    public class TodosController : Controller
    {
        private readonly AppDbContext _context;

        public TodosController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Todos.ToListAsync());
        }
    }
}
