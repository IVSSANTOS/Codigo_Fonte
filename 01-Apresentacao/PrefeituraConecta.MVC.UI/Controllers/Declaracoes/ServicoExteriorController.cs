using PrefeituraConecta.API.Negocio;
using PrefeituraConecta.MVC.UI.Models.Declaracoes;
using PrefeituraConecta.MVC.UI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrefeituraConecta.MVC.UI.Controllers.Declaracoes
{
    public class ServicoExteriorController : Controller
    {
        FiltroSimplesNacional_BS filtroSimplesNacional_BS = new FiltroSimplesNacional_BS();

        // GET: ReceitaDeclarada
        public ActionResult Index()
        {
            // Obter o filtro da consulta

            var filtroSimplesNacional = filtroSimplesNacional_BS.ObterFiltroSimplesNacional();

            if (filtroSimplesNacional.Consulta.Equals(Consulta.ICMS.Value))
            {
                return RedirectToAction("IncidenciaICMS");
            }
            else if (filtroSimplesNacional.Consulta.Equals(Consulta.ISSQN.Value))
            {
                return RedirectToAction("IncidenciaISSQN");
            }
            else if (filtroSimplesNacional.Consulta.Equals(Consulta.PADRAO.Value))
            {
                return RedirectToAction("IncidenciaICMS_e_ISSQN");
            }
            else
            {
                return View();
            }
        }

        public ActionResult IncidenciaICMS()
        {
            //var source = bs.ObterLista();

            //var lista = Mapper.Map<List<DECLARACOES_TRANSM_INCIDENCIA_ICMS_MODEL>>(source);

            var lista = new List<DECLARACOES_INCIDENCIA_ICMS_MODEL>(); // teste

            return View(lista);
        }

        // GET: DeclaracoesTransmitidas
        public ActionResult IncidenciaISSQN()
        {
            //var source = bs.ObterLista();

            //var lista = Mapper.Map<List<DECLARACOES_TRANSM_INCIDENCIA_ISSQN_MODEL>>(source);

            var lista = new List<DECLARACOES_INCIDENCIA_ISSQN_MODEL>(); // teste

            return View(lista);
        }

        // GET: DeclaracoesTransmitidas
        public ActionResult IncidenciaICMS_e_ISSQN()
        {
            //var source = bs.ObterLista();

            //var lista = Mapper.Map<List<DECLARACOES_TRANSM_INCIDENCIA_ISSQN_ICMS_MODEL>>(source);

            var lista = new List<DECLARACOES_INCIDENCIA_ISSQN_ICMS_MODEL>(); // teste

            return View(lista);
        }
    }
}