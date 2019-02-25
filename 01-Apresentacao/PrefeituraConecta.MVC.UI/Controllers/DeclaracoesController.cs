using PrefeituraConecta.MVC.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrefeituraConecta.MVC.UI.Controllers
{
    public class DeclaracoesController : Controller
    {
        // GET: Declaracoes
        [Authorize]
        public ActionResult Index()
        {
            try
            {
                return RedirectToAction("DeclaracoesEmpresas");
            }
            catch
            { 
                return View();
            }
        }

        public ActionResult DeclaracoesEmpresas()
        {
            var source = bs.ObterLista();

            var lista = Mapper.Map<List<DECLARACOES_INCIDENCIA_ISSQN_ICMS_MODEL>>(source);

            var Contador = new DeclaracoesModelEmpresas(); // teste

            return View(Contador);
        }
    }
}