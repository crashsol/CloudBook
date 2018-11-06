using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CloudBook.Configuration;
using CloudBook.Web;

namespace CloudBook.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CloudBookDbContextFactory : IDesignTimeDbContextFactory<CloudBookDbContext>
    {
        public CloudBookDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CloudBookDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            CloudBookDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CloudBookConsts.ConnectionStringName));

            return new CloudBookDbContext(builder.Options);
        }
    }
}
