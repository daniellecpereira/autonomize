using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autonomize.Models {
    [Table("Vendas")]
    public class Venda {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a data.")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o valor.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a quantidade.")]
        [Display(Name = "Quantidade")]
        public int QuantidadeVenda { get; set; }

        [Display(Name = "Tipo de pagamento")]
        public TipoPagamento Tipo { get; set; }

        [Display(Name = "Subtotal")]
        public decimal Subtotal { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o cliente.")]
        [Display(Name = "Cliente")]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Cliente? Cliente { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o produto.")]
        [Display(Name = "Produto")]
        public int ProdutoId { get; set; }

        [ForeignKey("ProdutoId")]
        public Produto? Produto { get; set; }

    }

    public enum TipoPagamento {
        Crédito,
        Débito,
        Dinheiro,
        PIX
    }
}
