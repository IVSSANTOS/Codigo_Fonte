using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrefeituraConecta.MVC.UI.Models
{
    public class FiltroNFSModel
    {
        [Display(Name = "Consolidado por)")]
        public string ConsolidadoPor { get; set; }

        [Display(Name = "Tomador)")]
        public string Tomador { get; set; }

        [Display(Name = "Pessoa Tomadora)")]
        public string PessoaTomadora { get; set; }

        [Display(Name = "Período por)")]
        public string PeriodoPor { get; set; }

        [Display(Name = "Dt. Emissão (De))")]
        public DateTime DtEmissaoDe { get; set; }

        [Display(Name = "Dt. Emissão (Até))")]
        public DateTime DtEmissaoAte { get; set; }

        [Display(Name = "Status")]
        public string Status { get; set; }

        [Display(Name = "Número da Nota")]
        public string NumeroNota { get; set; }

        [Display(Name = "CNPJ)")]
        public int CNPJ { get; set; }
    }
}