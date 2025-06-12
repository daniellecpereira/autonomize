using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Autonomize.Models {

    [Table("Relatorios")]
    public class Relatorio {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Quantidade deve ser preenchido!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Tipo de Item deve ser preenchido!")]
        [Display(Name = "Tipo de Item")]
        public TiposItem TipoItem { get; set; }

        [Required(ErrorMessage = "O campo Tipo de Item deve ser preenchido!")]
        [Display(Name = "Tipo de Alteração")]
        public TiposAlteracao TipoAlteracao { get; set; }

        [Required(ErrorMessage = "O campo Tipo de Relatório deve ser preenchido!")]
        [Display(Name = "Tipo de Relatório")]
        public TiposRelatorio TipoRelatorio { get; set; }

        [Required(ErrorMessage = "O campo Data Início deve ser preenchido!")]
        [Display(Name = "Data Início")]
        public DateTime DataInicio { get; set; }

        [Required(ErrorMessage = "O campo Data Final deve ser preenchido!")]
        [Display(Name = "Data Final")]
        public DateTime DataFinal { get; set; }

        public List<int> Itens { get; set; } = new List<int>();

        public List<Cliente> Clientes { get; set; } = new List<Cliente>();
        public List<Produto> Produtos { get; set; } = new List<Produto>();

        public Relatorio() {
        }

        //Construtor para Relatório de: Registro
        public Relatorio(string nome, TiposItem tipoItem, TiposAlteracao tipoAlteracao, TiposRelatorio tipoRelatorio, DateTime dataInicio, DateTime dataFinal) {

            Nome = nome;
            TipoItem = tipoItem;
            TipoAlteracao = tipoAlteracao;
            TipoRelatorio = tipoRelatorio;
            DataInicio = dataInicio;
            DataFinal = dataFinal;
        }

        //Construtor para Relatório de: Vendas
        public Relatorio(string nome, TiposRelatorio tipoRelatorio, DateTime dataInicio, DateTime dataFinal) {

            Nome = nome;
            TipoRelatorio = tipoRelatorio;
            DataInicio = dataInicio;
            DataFinal = dataFinal;
        }

        //Construtor para Relatório de: Produtos / Clientes
        public Relatorio(string nome, TiposRelatorio tipoRelatorio, List<int> itens, DateTime dataInicio, DateTime dataFinal) {

            Nome = nome;
            TipoRelatorio = tipoRelatorio;
            Itens = itens;
            DataInicio = dataInicio;
            DataFinal = dataFinal;
        }
    }

    public enum TiposRelatorio { Registros = 0, Vendas = 1, Produtos = 2, Cliente = 3 }
}
