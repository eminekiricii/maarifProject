using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using maarif.myproject.Configuration;
using maarif.myproject.Web;

namespace maarif.myproject.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class myprojectDbContextFactory : IDesignTimeDbContextFactory<myprojectDbContext>
    {
        public myprojectDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<myprojectDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            myprojectDbContextConfigurer.Configure(builder, configuration.GetConnectionString(myprojectConsts.ConnectionStringName));

            return new myprojectDbContext(builder.Options);
        }
    }
}
