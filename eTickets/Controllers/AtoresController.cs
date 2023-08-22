using eTickets.Data;
using eTickets.Data.Services;
using eTickets.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Controllers
{
    public class AtoresController : Controller
    {
        private readonly IAtoresService _service;

        public AtoresController(IAtoresService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        //Get: Atores/Create
        public async Task<IActionResult> Criar()
        {
            
            return View(); 
        }

        [HttpPost]
        public async Task<IActionResult> Criar([Bind("NomeCompleto, FotoDePerfilURL, Bio")] Ator ator) 
        {
            if (!ModelState.IsValid) 
            {
                return View(ator);
            }
            _service.Add(ator);
            return RedirectToAction(nameof(Index));
        }
    }
}
