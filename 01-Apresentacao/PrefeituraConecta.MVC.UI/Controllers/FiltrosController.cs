using AutoMapper;
using PrefeituraConecta.API.Negocio;
using PrefeituraConecta.MVC.UI.Models;
using PrefeituraConecta.MVC.UI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace PrefeituraConecta.MVC.UI.Controllers
{
    public class FiltrosController : Controller
    {
        private UsuarioBS usuarioBS = new UsuarioBS();
        private FiltroSimplesNacional_BS filtroSimplesNacional_BS = new FiltroSimplesNacional_BS();

        [Authorize]
        public ActionResult FiltroSimplesNacional()
        {

            ViewBag.tipoConsulta = new Consulta().FiltroSimplesNacionalEnumTipoConsulta();
            ViewBag.ConsolidadoPor = new ConsolidadoPor().FiltroSimplesNacionalEnumConsolidadoPor();
            ViewBag.TipoEmpresa = new TipoEmpresa().FiltroSimplesNacionalEnumTipoEmpresa();
            ViewBag.TipoDeclaracao = new TipoDeclaracao().FiltroSimplesNacionalEnumTipoDeclaracao();
            ViewBag.Regime = new Regime().FiltroSimplesNacionalEnumRegime();


            return View();
        }

        // POST: FiltroSimplesNacional/Create
        [HttpPost]
        public ActionResult CadastrarFiltroSimplesNacional(FormCollection model)
        {
            try
            {
                FiltroSimplesNacionalModel obj = new FiltroSimplesNacionalModel();
                obj.Consulta = model["consulta"].ToString();
                obj.ConsolidadoPor = model["consolidadopor"].ToString();
                obj.TipoEmpresa = model["tipoempresa"].ToString();
                obj.TipoDeclaracao = model["tipodeclaracao"].ToString();
                obj.Regime = model["regime"].ToString();
                obj.PeriodoApuracaoDe = model["apuracaoDe"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt32(model["apuracaoDe"].ToString().Replace("/", ""));
                obj.PeriodoApuracaoAte = model["apuracaoAte"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt32(model["apuracaoAte"].ToString().Replace("/", ""));
                obj.CNPJ = model["CNPJ"].ToString().Equals(string.Empty) ? 0 : Convert.ToInt32(model["CNPJ"].ToString());

                ClaimsPrincipal currentPrincipal = Thread.CurrentPrincipal as ClaimsPrincipal;
     
                Usuario usuario = new Usuario();
                usuario.Nome = currentPrincipal.Claims.ElementAt(0).Value;
                usuario.Login = currentPrincipal.Claims.ElementAt(1).Value;
                obj.ID_USUARIO = usuarioBS.ObterListaUsuario().FirstOrDefault(u => u.Login == usuario.Login && u.Nome == usuario.Nome).Id;


                bool retorno = filtroSimplesNacional_BS.Inserir(Mapper.Map<PrefeituraConecta.API.Entidades.FiltroSimplesNacional>(obj));
                

                if (retorno)
                {
                    TempData["Mensagem"] = "Cadastro realizado com sucesso.";
                }

                return RedirectToAction("FiltroSimplesNacional");
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        public ActionResult FiltroNFS()
        {
            return View();
        }


    }
}