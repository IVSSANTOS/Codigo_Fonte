using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrefeituraConecta.MVC.UI.Models
{
    [Table("TB_USUARIO")]
    public class Usuario
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(50)]
        public string Login { get; set; }

        [Required]
        [MaxLength(100)]
        public string Senha { get; set; }

        public TipoUsuario Tipo { get; set; } = TipoUsuario.Prefeitura;
    }
}