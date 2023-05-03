using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Repositories.EF_Core;

namespace Api.ContextFactory
{
    public class RepositoryFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            //ConfigurationBuilder
            var configuration = new ConfigurationBuilder() // AppSettings te İhtiyacımız olan Configuration oluşturma
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            //DbContextOptionBuilder
            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer(configuration.GetConnectionString("sqlConnection"), // AppSettings te İhtiyacımız olan Builder oluşturma
                prj => prj.MigrationsAssembly("Api"));

            return new RepositoryContext(builder.Options);
        }
    }
}
