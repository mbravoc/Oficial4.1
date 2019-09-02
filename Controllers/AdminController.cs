using Oficial4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oficial4.Controllers
{

    public class AdminController : Controller
    {
        catalogoOficialEntities db = new catalogoOficialEntities();

        // GET: Admin
        public ActionResult AcessoADMIN()
        {
            return View();

        }
        public JsonResult RetornaPesquisaADMINAjax(string texto)
        {

            var carros = db.Carro.Where(c => c.nome_Carro.ToUpper().Contains(texto.ToUpper()))
                                 .Select(c => new
                                 {
                                     type = "carro",
                                     codigo = c.id_carro,
                                     nome = c.nome_Carro,
                                     valor = 0.00,
                                     tipo = String.Empty,
                                 });

            var tipos = db.Tipo.Where(t => t.descricao.ToUpper().Contains(texto.ToUpper()))
                               .Select(t => new
                               {
                                   type = "tipo",
                                   codigo = t.id_Tipo,
                                   nome = t.descricao,
                                   valor = 0.00,
                                   tipo = String.Empty,
                               });


            var pecas = db.Pecas.Where(p => p.nome_Pecas.ToUpper().Contains(texto.ToUpper()))
                                .Select(p => new
                                {
                                    type = "peca",
                                    codigo = p.id_Pecas,
                                    nome = p.nome_Pecas,
                                    valor = p.preco_Pecas ?? 0,
                                    tipo = p.Tipo1.descricao,
                                });

            var consultaRetorno = carros.Union(tipos)
                                        .Union(pecas)
                                        .ToList();


            return Json(consultaRetorno, JsonRequestBehavior.AllowGet);
        }
    }
}