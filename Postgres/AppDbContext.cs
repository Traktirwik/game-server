using GameServer.Postgres.Models;
using Microsoft.EntityFrameworkCore;

namespace GameServer.Postgres;

public class AppDbContext : DbContext
{
    public DbSet<Lobby> Lobby { get; set; }
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=game;Username=macbookair;Password=admin");
    }
}