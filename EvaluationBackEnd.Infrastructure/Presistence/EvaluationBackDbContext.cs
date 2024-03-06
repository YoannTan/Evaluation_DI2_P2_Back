using EvaluationBackEnd.Data.Entities;
using EvaluationBackEnd.Infrastructure.Presistence.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EvaluationBackEnd.Infrastructure.Presistence;

public class EvaluationBackDbContext : DbContext
{
    public DbSet<Event> Events { get; set; }

    public EvaluationBackDbContext(DbContextOptions<EvaluationBackDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfiguration(new EventConfiguration());
    }
}