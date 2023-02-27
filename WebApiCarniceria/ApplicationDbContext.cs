using Microsoft.EntityFrameworkCore;
using WebApiCarniceria.Carniceria;

namespace WebApiCarniceria
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }
     }
    
}


