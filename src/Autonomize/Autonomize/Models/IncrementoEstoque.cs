using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autonomize.Models {

    [Table("IncrementoEstoque")]
    public class IncrementoEstoque {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tipo de operação")]
        public TipoOperacaoEstoque TipoOperacao { get; set; }

        [ForeignKey("ProdutoId")]
        [Required(ErrorMessage = "Selecione o produto")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        [Required(ErrorMessage = "Informe a quantidade da operação!")]
        public int Quantidade { get; set; }

        [Required]
        [Display(Name = "Motivo da operação")]
        public MotivoOperacaoEstoque MotivoOperacao { get; set; }

        public string Observacao { get; set; }

        [Required]
        [Display(Name = "Data de alteração")]
        public DateTime DataOperacao { get; set; } = DateTime.Now;
    }

    public enum TipoOperacaoEstoque {
        Entrada = 1,
        Saida = 2
    }

    public enum MotivoOperacaoEstoque {
        Venda = 1,
        Compra = 2,
        Perda = 3
    }
}
