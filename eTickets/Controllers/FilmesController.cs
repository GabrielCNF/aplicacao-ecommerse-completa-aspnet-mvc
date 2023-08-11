using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class FilmesController : Controller
    {
        private readonly AppDbContext _context;

        public FilmesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allFilmes = await _context.Filmes.Include(n => n.Cinema).OrderBy(n => n.Nome).ToListAsync();
            return View(allFilmes);
        }
    }
}
