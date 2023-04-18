using ListaDB.DAL;
using ListaDB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListaDB.Controllers
{
    public class SalaController : Controller
    {
        SalaDAO tbSala = new SalaDAO();

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.listasalas = tbSala.getTodaAsSalas();
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string descricao)
        {
            Sala novaSala = new Sala();
            novaSala.SALADESC = descricao;
            tbSala.insertSala(novaSala);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Atualizar(int id)
        {
            ViewBag.salaAtualizar = tbSala.getTodaAsSalas().Where(x => x.SALAID == id).FirstOrDefault();
            return View();
        }
        [HttpPost]
        public IActionResult Atualizar(string codigo, string descricao)
        {

            Sala atualizaSala = new Sala();
            atualizaSala.SALAID = Convert.ToInt32(codigo);
            atualizaSala.SALADESC = descricao;
            tbSala.updateSala(atualizaSala);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Apagar(int id)
        {

            Sala atualizaSala = new Sala();
            atualizaSala.SALAID = Convert.ToInt32(id);
            tbSala.apgarSala(atualizaSala);

            return RedirectToAction("Index");
        }

    }

}

