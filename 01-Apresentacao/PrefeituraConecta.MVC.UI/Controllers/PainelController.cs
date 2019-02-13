using PrefeituraConecta.API.Dados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrefeituraConecta.MVC.UI.Controllers
{
    public class PainelController : Controller
    {
        
        // GET: Painel
        [Authorize]
        public ActionResult Index()
        {
            if (User.IsInRole("Padrão"))
            {
                ViewBag.Mensagem = "Você é um usuário padrão e não poderá alterar dados do sistema!";
            }
            return View();
        }

        //DBConfiguration context = new DBConfiguration();
        //[Authorize]
        //public ActionResult GetData()
        //{
        //    int masculino = context.TB_GRAFICO.Where(x => x.Genero == "MASCULINO").Count();
        //    int feminino = context.TB_GRAFICO.Where(x => x.Genero == "FEMININO").Count();
        //    int outros = context.TB_GRAFICO.Where(x => x.Genero == "OUTROS").Count();
        //    Radio obj = new Radio();
        //    obj.MASCULINO = masculino;
        //    obj.FEMININO = feminino;
        //    obj.OUTROS = outros;

        //    return Json(obj,JsonRequestBehavior.AllowGet);
        //}

        //public class Radio
        //{
        //    public int MASCULINO { get; set; }
        //    public int FEMININO { get; set; }
        //    public int OUTROS { get; set; }
        //}

    }
}