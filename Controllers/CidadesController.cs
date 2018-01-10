using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjetoCidades.Models;

namespace ProjetoCidades.Controllers
{
    public class CidadesController: Controller
    {
        Cidade cidade = new Cidade();
        public IActionResult Index()
        {
            var lista = cidade.ListarCidades();
            return View(lista);
        }

        public IActionResult CidadesEstados()
        {
            var lista = cidade.ListarCidades();
            return View(lista);
        }

        public IActionResult TodosDados()
        {
            var lista = cidade.ListarCidades();
            return View(lista);
        }

        public IActionResult MaiorCidade()
        {
            var lista = cidade.ListarCidades().OrderByDescending(x => x.habitantes).First();
            return View(lista);
        }

         public IActionResult MenorCidade()
        {
            var lista = cidade.ListarCidades().OrderByDescending(x => x.habitantes).Last();
            return View(lista);
        }
    }
}