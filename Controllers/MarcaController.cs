using contrleCarro.Models;
using contrleCarro.Repositorio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace contrleCarro.Controllers
{
    public class MarcaController : Controller
    {
        private readonly IMarcaRepositorio _marcaRepositorio;

        public MarcaController(IMarcaRepositorio marcaRepositorio)
        {
            _marcaRepositorio = marcaRepositorio;
        }

        public IActionResult Index()
        {
            List<MarcaModel> marca = _marcaRepositorio.BuscarTodos();
            

            return View(marca);
        }

        public IActionResult CriarMarcas()
        {
            
            
            return View();
        }
        
        [HttpPost]
        public IActionResult CriarMarcas(MarcaModel contato)
        {
            _marcaRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        }
    }
}
