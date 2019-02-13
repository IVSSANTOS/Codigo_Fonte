using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace PrefeituraConecta.MVC.UI.ViewModels
{
    public class LoginViewModel
    {
        public string urlRetorno { get; set; }

        [Required(ErrorMessage = "Informe o Login")]
        [MaxLength(50, ErrorMessage = "O Login deve ter até 50 caracteres")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Informe a Senha")]
        [DataType(DataType.Password)]
        [MinLength(6, ErrorMessage = "O Senha deve ter pelo menos 6 caracteres")]
        public string Senha { get; set; }

    }
}