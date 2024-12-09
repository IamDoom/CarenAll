using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace CarenAll.Models
{
    public class DataDBContextFactory : IDesignTimeDbContextFactory<DataDBContext>
    {
        public DataDBContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<DataDBContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DevConnection"));

            return new DataDBContext(optionsBuilder.Options);
        }
    }
}
