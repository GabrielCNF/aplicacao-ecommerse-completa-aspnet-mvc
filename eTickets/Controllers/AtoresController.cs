using eTickets.Data;
using eTickets.Data.Services;
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
    }
}
