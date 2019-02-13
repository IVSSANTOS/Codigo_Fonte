using System.ComponentModel.DataAnnotations;

namespace PrefeituraConecta.MVC.UI.ViewModels
{
    public class AlterarSenhaViewModel
    {
        [Required(ErrorMessage ="Informe sua senha atual")]
        [DataType(DataType.Password)]
        [Display(Name ="Senha Atual")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]
        public string SenhaAtual { get; set; }

        [Required(ErrorMessage = "Informe sua nova senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Nova Senha")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]
        public string NovaSenha { get; set; }

        [Required(ErrorMessage = "Confirme sua nova senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirmar Senha")]
        [MinLength(6, ErrorMessage = "A senha deve ter pelo menos 6 caracteres")]
        [Compare(nameof(NovaSenha), ErrorMessage ="A senha e a confirmação não estão iguais")]
        public string ConfirmacaoSenha { get; set; }

    }
}