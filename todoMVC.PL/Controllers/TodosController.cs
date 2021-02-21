using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using todoMVC.DL;
using todoMVC.DL.Models;

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
            ViewBag.Title = "";
            return View(await _context.Todos.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddTodo(string title)
        {

            var todoToAdd = new Todo() { Title = title };
            await _context.AddAsync(todoToAdd);
            await _context.SaveChangesAsync();
            return Redirect(nameof(Index));
        }
    }
}
