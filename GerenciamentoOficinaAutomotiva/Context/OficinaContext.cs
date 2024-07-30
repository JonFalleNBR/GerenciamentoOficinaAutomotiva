using GerenciamentoOficinaAutomotiva.Model;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoOficinaAutomotiva.Context
{
    internal class OficinaContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<DescricaoServico> DescricaoServicos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            optionBuilder.UseNpgsql(
                "Server=localhost;" +
                "Port=5432;" +
                "Database=OficinaDB;" +
                "Username=postgres;" + // Usuário correto
                "Password=postgres"
                ); 

        }
    }
}
