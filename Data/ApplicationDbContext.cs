using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProyectoFinal.Models;

namespace ProyectoFinal.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Cliente> Clientes { get; set; }

    public DbSet<Producto> Productos { get; set; }

    public DbSet<Promocion> Promociones { get; set; }

    public DbSet<Pedido> Pedidos { get; set; }

    // public DbSet<DetallePedido> DetallePedidos { get; set; }
}
