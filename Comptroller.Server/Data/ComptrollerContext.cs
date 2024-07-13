using Comptroller.Server.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Comptroller.Server.Data;
public class ComptrollerContext : DbContext
{
    private readonly IConfiguration _configuration;

    public ComptrollerContext(DbContextOptions<ComptrollerContext> options, IConfiguration configuration)
        : base(options)
    {
        _configuration = configuration;
    }

    public DbSet<Occupant> Occupants { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            var connectionString = _configuration.GetConnectionString("ComptrollerDatabase");
            optionsBuilder.UseNpgsql(connectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Set the default schema
        modelBuilder.HasDefaultSchema("development");

        // Apply the schema to all entities (optional)
        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            entityType.SetSchema("development");
        }
    }
}
