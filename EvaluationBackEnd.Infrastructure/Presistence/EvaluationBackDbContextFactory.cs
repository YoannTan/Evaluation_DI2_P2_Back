using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EvaluationBackEnd.Infrastructure.Presistence;

public class EvaluationBackDbContextFactory : IDesignTimeDbContextFactory<EvaluationBackDbContext>
{
    private readonly string _connectionString = "Data Source=localhost;Database=Evaluation_DI2_P2;Integrated Security=sspi;TrustServerCertificate=True";

    public EvaluationBackDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<EvaluationBackDbContext>();
        optionsBuilder.UseSqlServer(_connectionString);

        return new EvaluationBackDbContext(optionsBuilder.Options);
    }
}