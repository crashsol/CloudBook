using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using CloudBook.Authorization.Roles;
using CloudBook.Authorization.Users;
using CloudBook.MultiTenancy;
using CloudBook.Books;
using CloudBook.EntityMapper.Books;
using CloudBook.EntityMapper.BookTags;

namespace CloudBook.EntityFrameworkCore
{
    public class CloudBookDbContext : AbpZeroDbContext<Tenant, Role, User, CloudBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        

        public DbSet<Book> Books { get; set; }

        public DbSet<BookList> BookLists { get; set; }

        public DbSet<BookTag> BookTags { get; set; }
        public CloudBookDbContext(DbContextOptions<CloudBookDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookCfg());
            modelBuilder.ApplyConfiguration(new BookTagCfg());
        }
    }
}
