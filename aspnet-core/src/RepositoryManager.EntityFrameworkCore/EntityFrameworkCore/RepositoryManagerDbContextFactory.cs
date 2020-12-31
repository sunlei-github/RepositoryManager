using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RepositoryManager.Configuration;
using RepositoryManager.Web;

namespace RepositoryManager.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class RepositoryManagerDbContextFactory : IDesignTimeDbContextFactory<RepositoryManagerDbContext>
    {
        public RepositoryManagerDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RepositoryManagerDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            RepositoryManagerDbContextConfigurer.Configure(builder, configuration.GetConnectionString(RepositoryManagerConsts.ConnectionStringName));

            return new RepositoryManagerDbContext(builder.Options);
        }
    }
}
