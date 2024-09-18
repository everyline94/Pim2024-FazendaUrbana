using Microsoft.EntityFrameworkCore;
using Pim2024_FazendaUrbana.Models;

namespace Pim2024_FazendaUrbana.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<ControleProducao> ControleProducoes { get; set; }
        public DbSet<Insumo> Insumos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ItemVenda> ItensVenda { get; set; }
    }
}
