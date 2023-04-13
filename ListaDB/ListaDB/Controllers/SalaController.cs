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



    }

}

