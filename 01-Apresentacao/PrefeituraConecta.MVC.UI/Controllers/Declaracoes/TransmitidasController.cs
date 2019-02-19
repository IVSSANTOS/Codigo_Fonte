using AutoMapper;
using PrefeituraConecta.API.Negocio;
using PrefeituraConecta.MVC.UI.Models;
using PrefeituraConecta.MVC.UI.Models.Declaracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrefeituraConecta.MVC.UI.Controllers.Declaracoes
{
    [Authorize]
    public class TransmitidasController : Controller
    {
        private VALOR_APURADO_EMPRESAS_BS bs = new VALOR_APURADO_EMPRESAS_BS();

        // GET: DeclaracoesTransmitidas
        public ActionResult Index()
        {
            // Obter o filtro da consulta

            var consulta = "IncidenciaICMS";

            switch (consulta)
            {
                case "IncidenciaICMS":
                    
                    try
                    {
                        // TODO: Add insert logic here

                        return RedirectToAction("IncidenciaICMS");
                    }
                    catch
                    {
                        return View();
                    }


                case "IncidenciaISSQN":

                    try
                    {
                        // TODO: Add insert logic here

                        return RedirectToAction("IncidenciaISSQN");
                    }
                    catch
                    {
                        return View();
                    }

                case "IncidenciaICMS_e_ISSQN":

                    try
                    {
                        // TODO: Add insert logic here

                        return RedirectToAction("IncidenciaICMS_e_ISSQN");
                    }
                    catch
                    {
                        return View();
                    }

            }


            return View();
        }

        
        // GET: DeclaracoesTransmitidas

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
