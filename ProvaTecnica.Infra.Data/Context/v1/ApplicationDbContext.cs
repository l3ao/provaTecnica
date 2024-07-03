using Microsoft.EntityFrameworkCore;
using ProvaTecnica.Domain.Entities.v1;

namespace ProvaTecnica.InfraData.Context.v1;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options) : base(options) { }
    
    public DbSet<Company> Companies { get; init; }
    public DbSet<Client> Clients { get; init; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}