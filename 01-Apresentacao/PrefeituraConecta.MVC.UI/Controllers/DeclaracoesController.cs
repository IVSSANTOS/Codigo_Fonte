using AutoMapper;
using PrefeituraConecta.API.Negocio;
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
        Declaracoes_BS bs = new Declaracoes_BS();

        // GET: Declaracoes
        [Authorize]
        public ActionResult Index()
        {
            
        }
    }
}