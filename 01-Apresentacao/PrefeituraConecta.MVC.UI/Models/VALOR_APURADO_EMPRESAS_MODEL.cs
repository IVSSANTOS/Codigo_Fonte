using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace PrefeituraConecta.MVC.UI.Models
{
    public class VALOR_APURADO_EMPRESAS_MODEL
    {
        [Display()]
        public int ID_CONTRIBUINTE { get; set; }

        [Display(Name ="CNPJ (Matriz)")]
        public long CNPJMATRIZ { get; set; }

        [Display(Name = "Razão Social")]
        public string NOME { get; set; }

        [Display(Name = "Receita Total")]
        public decimal RPA { get; set; }
        public int ID_PREFEITURA { get; set; }

        [Display(Name = "Inc. de ISSQN")]
        public decimal VALOR_APURADO_DE_ISS { get; set; }

        [Display(Name = "Inc. de ICMS")]
        public decimal VALOR_APURADO_DE_ICMS { get; set; }
    }
}