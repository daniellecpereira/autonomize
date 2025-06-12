using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autonomize.Models {
    [Table("Clientes")]
    public class Cliente {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome!")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Display(Name = "Telefone")]
        public string Telefone { get; set; }


        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Obrigatório informar CPF ou CNPJ")]
        [Display(Name = "CPF ou CNPJ")]
        public string CpfCnpj { get; set; }

        [Required(ErrorMessage = "Obrigatório informar endereço!")]
        [Display(Name = "Endereço do Cliente")]
        public string Endereco { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime? DataCadastro { get; set; } = DateTime.Now;

    }
}
