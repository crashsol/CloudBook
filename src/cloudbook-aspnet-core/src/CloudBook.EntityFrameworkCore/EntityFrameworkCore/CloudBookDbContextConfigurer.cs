using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CloudBook.EntityFrameworkCore
{
    public static class CloudBookDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CloudBookDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CloudBookDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
