using AutoMapper;
using PrefeituraConecta.API.Negocio;
using PrefeituraConecta.MVC.UI.Models;
using PrefeituraConecta.MVC.UI.Models.Declaracoes;
using PrefeituraConecta.MVC.UI.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrefeituraConecta.MVC.UI.Controllers.Declaracoes
{
    public class ServicoLocacaoController : Controller
    {
        FiltroSimplesNacional_BS filtroSimplesNacional_BS = new FiltroSimplesNacional_BS();

        [Authorize]
        public ActionResult Index()
        {
            // Obter o filtro da consulta

            var source = filtroSimplesNacional_BS.ObterFiltroSimplesNacional();

            FiltroSimplesNacionalModel filtroSimplesNacional = Mapper.Map<FiltroSimplesNacionalModel>(source);


            if (filtroSimplesNacional.Consulta.Equals(Consulta.ICMS.Value))
            {
                return RedirectToAction("IncidenciaICMS", filtroSimplesNacional);
            }
            else if (filtroSimplesNacional.Consulta.Equals(Consulta.ISSQN.Value))
            {
                return RedirectToAction("IncidenciaISSQN", filtroSimplesNacional);
            }
            else if (filtroSimplesNacional.Consulta.Equals(Consulta.PADRAO.Value))
            {
                return RedirectToAction("IncidenciaICMS_e_ISSQN", filtroSimplesNacional);
            }
            else
            {
                return View();
            }

        }
        [Authorize]
        public ActionResult IncidenciaICMS(FiltroSimplesNacionalModel filtroSimplesNacional)
        {
            ViewBag.tipoConsulta = filtroSimplesNacional.Consulta;
            ViewBag.ConsolidadoPor = filtroSimplesNacional.ConsolidadoPor;
            ViewBag.TipoEmpresa = filtroSimplesNacional.TipoEmpresa;
            ViewBag.TipoDeclaracao = filtroSimplesNacional.TipoDeclaracao;
            ViewBag.Regime = filtroSimplesNacional.Regime;
            ViewBag.CNPJ = filtroSimplesNacional.CNPJ;
            ViewBag.PeriodoApuracaoDe = filtroSimplesNacional.PeriodoApuracaoDe;
            ViewBag.PeriodoApuracaoAte = filtroSimplesNacional.PeriodoApuracaoAte;

            //var source = bs.ObterLista();

            //var lista = Mapper.Map<List<DECLARACOES_TRANSM_INCIDENCIA_ICMS_MODEL>>(source);

            var lista = new List<DECLARACOES_INCIDENCIA_ICMS_MODEL>(); // teste

            return View(lista);
        }
        [Authorize]
        public ActionResult IncidenciaISSQN(FiltroSimplesNacionalModel filtroSimplesNacional)
        {
            ViewBag.tipoConsulta = filtroSimplesNacional.Consulta;
            ViewBag.ConsolidadoPor = filtroSimplesNacional.ConsolidadoPor;
            ViewBag.TipoEmpresa = filtroSimplesNacional.TipoEmpresa;
            ViewBag.TipoDeclaracao = filtroSimplesNacional.TipoDeclaracao;
            ViewBag.Regime = filtroSimplesNacional.Regime;
            ViewBag.CNPJ = filtroSimplesNacional.CNPJ;
            ViewBag.PeriodoApuracaoDe = filtroSimplesNacional.PeriodoApuracaoDe;
            ViewBag.PeriodoApuracaoAte = filtroSimplesNacional.PeriodoApuracaoAte;

            //var source = bs.ObterLista();

            //var lista = Mapper.Map<List<DECLARACOES_TRANSM_INCIDENCIA_ISSQN_MODEL>>(source);

            var lista = new List<DECLARACOES_INCIDENCIA_ISSQN_MODEL>(); // teste

            return View(lista);
        }
        [Authorize]
        public ActionResult IncidenciaICMS_e_ISSQN(FiltroSimplesNacionalModel filtroSimplesNacional)
        {
            ViewBag.tipoConsulta = filtroSimplesNacional.Consulta;
            ViewBag.ConsolidadoPor = filtroSimplesNacional.ConsolidadoPor;
            ViewBag.TipoEmpresa = filtroSimplesNacional.TipoEmpresa;
            ViewBag.TipoDeclaracao = filtroSimplesNacional.TipoDeclaracao;
            ViewBag.Regime = filtroSimplesNacional.Regime;
            ViewBag.CNPJ = filtroSimplesNacional.CNPJ;
            ViewBag.PeriodoApuracaoDe = filtroSimplesNacional.PeriodoApuracaoDe;
            ViewBag.PeriodoApuracaoAte = filtroSimplesNacional.PeriodoApuracaoAte;

            //var source = bs.ObterLista();

            //var lista = Mapper.Map<List<DECLARACOES_TRANSM_INCIDENCIA_ISSQN_ICMS_MODEL>>(source);

            var lista = new List<DECLARACOES_INCIDENCIA_ISSQN_ICMS_MODEL>(); // teste

            return View(lista);
        }
    }
}