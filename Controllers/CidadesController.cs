using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjetoCidades.Models;
using ProjetoCidades.Repositorio;

namespace ProjetoCidades.Controllers
{
    public class CidadesController: Controller
    {
        CidadeRep cidaderep = new CidadeRep();
        public IActionResult Index()
        {
            var lista = cidaderep.Listar();
            return View(lista);
        }

        public IActionResult CidadesEstados()
        {
            var lista = cidaderep.Listar();
            return View(lista);
        }

        public IActionResult TodosDados()
        {
            var lista = cidaderep.Listar();
            return View(lista);
        }

        public IActionResult MaiorCidade()
        {
            var lista = cidaderep.Listar().OrderByDescending(x => x.habitantes).First();
            return View(lista);
        }

         public IActionResult MenorCidade()
        {
            var lista = cidaderep.Listar().OrderByDescending(x => x.habitantes).Last();
            return View(lista);
        }
    }
}