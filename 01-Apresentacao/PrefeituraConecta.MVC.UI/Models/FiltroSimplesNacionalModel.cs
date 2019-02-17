using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrefeituraConecta.MVC.UI.Models
{
    public class FiltroSimplesNacionalModel
    {

        public int ID_CONSULTA { get; set; }

        [Display(Name = "Consulta)")]
        public string Consulta { get; set; }

        [Display(Name = "Consolidado por")]
        public string ConsolidadoPor { get; set; }

        [Display(Name = "Tipo de Empresa")]
        public string TipoEmpresa { get; set; }

        [Display(Name = "Tipo da Declaração")]
        public string TipoDeclaracao { get; set; }

        [Display(Name = "Regime")]
        public string Regime { get; set; }

        [Display(Name = "Período Apuração (De)")]
        public DateTime PeriodoApuracaoDe { get; set; }

        [Display(Name = "Período Apuração (Ate)")]
        public DateTime PeriodoApuracaoAte { get; set; }

        [Display(Name = "CNPJ")]
        public int CNPJ { get; set; }
    }
}