﻿using Oficial4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oficial4.Controllers
{
    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            catalogoOficialEntities db = new catalogoOficialEntities();

            List<Carro> carros = new List<Carro>();

            carros = db.Carro.ToList();
            ViewBag.Carros = carros;
            ViewBag.Carros = new SelectList(db.Carro, "id_Carro", "nome_Carro");
            return View();
        }
    }
}