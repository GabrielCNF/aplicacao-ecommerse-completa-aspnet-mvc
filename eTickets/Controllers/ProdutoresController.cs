using eTickets.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class ProdutoresController : Controller
    {
        private readonly AppDbContext _context;

        public ProdutoresController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProdutores = await _context.Produtores.ToListAsync();
            return View(allProdutores);
        }
    }
}
