using Microsoft.EntityFrameworkCore;

namespace Controle_De_OS.Models
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) {}

        public DbSet<Atendente> Atendentes { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Procedimento> Procedimentos { get; set; }
        public DbSet<Tecnico> Tecnicos { get; set; }
        public DbSet<Cidade> Cidades { get; set; }

    }
}
