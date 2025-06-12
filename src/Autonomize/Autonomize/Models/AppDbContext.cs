using Microsoft.EntityFrameworkCore;

namespace Autonomize.Models {
    public class AppDbContext : DbContext {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TiposProduto> TipoProdutos { get; set; }
        public DbSet<IncrementoEstoque> IncrementoEstoques { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Consumos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Relatorio> Relatorios { get; set; }
        public DbSet<Historico> Historicos { get; set; }
    }
}
