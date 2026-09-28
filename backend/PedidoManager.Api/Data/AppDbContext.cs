using Microsoft.EntityFrameworkCore;
using PedidoManager.Api.Entities;

namespace PedidoManager.Api.Data 
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) 
        { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}