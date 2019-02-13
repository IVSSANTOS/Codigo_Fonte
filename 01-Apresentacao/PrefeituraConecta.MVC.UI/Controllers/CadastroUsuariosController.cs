using PrefeituraConecta.MVC.UI.Filters;
using PrefeituraConecta.MVC.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrefeituraConecta.MVC.UI.Controllers
{
    public class CadastroUsuariosController : Controller
    {
        [AutorizacaoTipo(new[] { TipoUsuario.Administrador, TipoUsuario.Consultor })]
        public ActionResult Index()
        {
            return View();
        }
    }
}
