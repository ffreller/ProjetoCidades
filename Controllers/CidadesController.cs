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

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar([Bind] Cidade cidade)
        {
            cidaderep.Cadastrar(cidade);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Editar(int? id)
        {
            Cidade cidade = cidaderep.Listar().Where(x => x.id == id).FirstOrDefault();
            return View(cidade);
        }

        [HttpPost]
        public IActionResult Editar([Bind] Cidade cidade)
        {
            cidaderep.Editar(cidade);
            return RedirectToAction("Index");
        }

        public IActionResult Excluir(Cidade cidade)
        {
            cidaderep.Excluir(cidade); 
            return RedirectToAction("Index");
        }

        public IActionResult Detalhes(int? id)
        {
            var cidade = cidaderep.Listar().Where(x => x.id == id).FirstOrDefault();
            return View(cidade);
        }
    

    }
}