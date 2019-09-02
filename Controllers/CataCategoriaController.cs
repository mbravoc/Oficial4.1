using Oficial4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oficial4.Controllers
{
    public class CataCategoriaController : Controller
    {
        // GET: Categoria
        catalogoOficialEntities db = new catalogoOficialEntities();

        //public ActionResult CatalogoCategoria(int id)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        cadastrar o TODOS no banco
        //        esse TODOS vai ter um id

        //         if (id == todos(1001)
        //        if (id == 1001)
        //                List<Tipo> TipoInfo = db.Tipo.ToList();
        //        {
        //            List<Tipo> TipoInfo = db.Tipo.ToList();
        //        }
        //        else
        //        {
        //             else
        //                List<Tipo> TipoInfo = db.Tipo.Where(x => x.id_Tipo == id).ToList();

        //            return View(/*db.Tipo.ToList()*/TipoInfo);


        //        }
        //    }// fim if
        //    return RedirectToAction("CatalogoCategoria", "CataCategoria", new { id = 1002 });

        //}
        public ActionResult CatalogoCategoria(int? id)
        {
            Session["idCarroCliente"] = id;
            catalogoOficialEntities db = new catalogoOficialEntities();

            List<Tipo> tipos = db.Tipo.ToList();

            ViewBag.Tipos = tipos;
            //ViewBag.Tipos = new SelectList(db.Tipo, "id_Tipo", "descricao");
            return View();
        }
        public JsonResult RetornaPecasCatalogoAjax(int? id)
        {
            var idCarro = Convert.ToInt32(Session["idCarroCliente"] ?? 0);

            dynamic pecas = db.Pecas.Where(p => p.carro == idCarro || p.carro == null)
                                    .Where(p => p.tipo == id)
                                    .Select(p => new {
                                        p.id_Pecas,
                                        p.nome_Pecas,
                                        p.preco_Pecas,
                                        Tipo1 = new
                                        {
                                            descricao = p.Tipo1.descricao
                                        }
                                    });

            return Json(pecas, JsonRequestBehavior.AllowGet);
        }
    }
}







