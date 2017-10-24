using LojaComputadores.Models;
using Microsoft.EntityFrameworkCore;

namespace LojaComputadores
{   //Conexão com banco de dados
    public class LojaContext : DbContext
    {
        public LojaContext(DbContextOptions options) : base(options) { }

        public DbSet<Computador> Computadores { get; set; }
    }
}
