using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using RepositoryManager.Authorization.Roles;
using RepositoryManager.Authorization.Users;
using RepositoryManager.MultiTenancy;

namespace RepositoryManager.EntityFrameworkCore
{
    public class RepositoryManagerDbContext : AbpZeroDbContext<Tenant, Role, User, RepositoryManagerDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public RepositoryManagerDbContext(DbContextOptions<RepositoryManagerDbContext> options)
            : base(options)
        {
        }
    }
}
