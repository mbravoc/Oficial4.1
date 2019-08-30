using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oficial4.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult AcessoADMIN()
        {
            return View();

        }
        public ActionResult TelaAdmin() {
            return View();
        }
    }
}