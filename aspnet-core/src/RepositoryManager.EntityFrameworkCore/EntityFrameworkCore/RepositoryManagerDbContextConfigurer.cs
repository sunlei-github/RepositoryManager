using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace RepositoryManager.EntityFrameworkCore
{
    public static class RepositoryManagerDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RepositoryManagerDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RepositoryManagerDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
