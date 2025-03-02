using Dima.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Dima.Api.Data;

public class AppDbContext : DbContext
{
    public DbSet<Categoria> Categorias { get; set; } = null!;
    public DbSet<Transacao> Transacoes { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration();
    }
}