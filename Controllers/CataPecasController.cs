using Oficial4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oficial4.Controllers
{
    public class CataPecasController : Controller
    {
        // GET: Catalogo
        // catalogo que mostra as peças listadas
        catalogoOficialEntities db = new catalogoOficialEntities();
        public ActionResult IndexAjaxCatalogo()
        {
            return View(db.Pecas.ToList());
        }

        public ActionResult CatalogoPecas(int id)
        {
            //List<Pecas> PecasInfo = db.PecasInfo.Where(x => x.id_Pecas == id).ToList();
            Pecas PecasInfo = db.Pecas.FirstOrDefault(x => x.id_Pecas == id);
            return View(PecasInfo);
        }
    }
}