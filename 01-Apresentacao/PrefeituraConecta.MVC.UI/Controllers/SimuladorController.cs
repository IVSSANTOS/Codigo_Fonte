using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrefeituraConecta.MVC.UI.Controllers
{
    public class SimuladorController : Controller
    {
        // GET: Simulador
        public ActionResult SimuladorSimples()
        {
            return View();
        }

        public ActionResult SimuladorCompleto()
        {
            return View();
        }
    }
}