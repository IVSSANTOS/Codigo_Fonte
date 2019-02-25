using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrefeituraConecta.MVC.UI.Models
{
    public class DeclaracoesModelEmpresas
    {
        [Display(Name = "Empresas")]
        public decimal EMPRESAS { get; set; }
    }
}