using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrefeituraConecta.MVC.UI.Controllers
{
    public class FiltrosController : Controller
    {
        // GET: Filtros
        [Authorize]
        public ActionResult FiltroSimplesNacional()
        {
            return View();
        }
    }
}