using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrefeituraConecta.MVC.UI.Models.Declaracoes
{
    public class DECLARACOES_INCIDENCIA_ISSQN_MODEL
    {
        public int ID_CONTRIBUINTE { get; set; }

        [Display(Name = "CNPJ (Matriz)")]
        public long CNPJMATRIZ { get; set; }

        [Display(Name = "Razão Social")]
        public string NOME { get; set; }

        [Display(Name = "Receita Total")]
        public decimal RPA { get; set; }

        [Display(Name = "S.Retençao")]
        public decimal SEM_RETENCAO { get; set; }

        [Display(Name = "C.Retençao")]
        public decimal COM_RETENCAO { get; set; }

        [Display(Name = "Outros.M")]
        public decimal OUTROS_M { get; set; }

        [Display(Name = "Contabilidade")]
        public decimal CONTABILIDADE { get; set; }
                
        public int ID_PREFEITURA { get; set; }

        [Display(Name = "Locação")]
        public decimal LOCACAO { get; set; }

        [Display(Name = "Exterior")]
        public decimal EXTERIOR { get; set; }
    }
}