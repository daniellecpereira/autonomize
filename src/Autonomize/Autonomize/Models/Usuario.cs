using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autonomize.Models {
    [Table("Usuarios")]
    public class Usuario {
        [Key]
        public int IDUsuario { get; set; }

        [Display(Name = "Nome")]
        public string NomeUsuario { get; set; }

        [Display(Name = "Email")]
        public string EmailUsuario { get; set; }

        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Display(Name = "Perfil")]
        public string TipoUsuario { get; set; }
    }
}
