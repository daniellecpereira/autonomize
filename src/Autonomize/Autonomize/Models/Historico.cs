using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autonomize.Models {
    [Table("Historico")]
    public class Historico {

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tipo de Item")]
        public TiposItem TipoItem { get; set; }

        [Required]
        [Display(Name = "Tipo de Alteração")]
        public TiposAlteracao TipoAlteracao { get; set; }

        [Required]
        public int IdItem { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [Display(Name = "Data de Registro")]
        [DataType(DataType.DateTime)]
        public DateTime DataRegistro { get; set; }

        [Required]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        public Historico(TiposItem tipoItem, TiposAlteracao tipoAlteracao, int idItem, string nome, DateTime dataRegistro) {
            TipoItem = tipoItem;
            TipoAlteracao = tipoAlteracao;
            IdItem = idItem;
            Nome = nome;
            DataRegistro = dataRegistro;
        }
        public Historico(TiposItem tipoItem, TiposAlteracao tipoAlteracao, int idItem, string nome, DateTime dataRegistro, int quantidade) {
            TipoItem = tipoItem;
            TipoAlteracao = tipoAlteracao;
            IdItem = idItem;
            Nome = nome;
            DataRegistro = dataRegistro;
            Quantidade = quantidade;
        }
    }

    public enum TiposItem { Produto = 0, Venda = 1, Cliente = 2, Outro = 3 }

    public enum TiposAlteracao { Create = 0, Add = 1, Edit = 2, Delete = 3, Outro = 4 }

}
