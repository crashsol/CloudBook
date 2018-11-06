using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CloudBook.Authorization.Roles;
using CloudBook.Authorization.Users;
using CloudBook.MultiTenancy;

namespace CloudBook.EntityFrameworkCore
{
    public class CloudBookDbContext : AbpZeroDbContext<Tenant, Role, User, CloudBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public CloudBookDbContext(DbContextOptions<CloudBookDbContext> options)
            : base(options)
        {
        }
    }
}
