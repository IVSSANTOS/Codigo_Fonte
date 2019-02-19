using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrefeituraConecta.MVC.UI.Models.Declaracoes
{
    public class DECLARACOES_INCIDENCIA_ICMS_MODEL
    {
        public int ID_CONTRIBUINTE { get; set; }

        [Display(Name = "CNPJ (Matriz)")]
        public long CNPJMATRIZ { get; set; }

        [Display(Name = "Razão Social")]
        public string NOME { get; set; }

        [Display(Name = "Receita Total")]
        public decimal RPA { get; set; }

        public int ID_PREFEITURA { get; set; }

        [Display(Name = "Mercado Interno")]
        public decimal MERCADO_INTERNO { get; set; }
        
        [Display(Name = "Exportação")]
        public decimal EXPORTACAO { get; set; }
    }
}