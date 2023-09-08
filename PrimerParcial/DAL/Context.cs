using Microsoft.EntityFrameworkCore;
using PrimerParcial.Model;
namespace PrimerParcial.DAL
{
    public class Context : DbContext
    {
        public DbSet<Ingresos> Ingresos { get; set; }

        public Context(DbContextOptions<Context> options) : base(options) { }
    }
}
