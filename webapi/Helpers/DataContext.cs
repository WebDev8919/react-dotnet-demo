namespace webapi.Helpers;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using webapi.Entities;

public class DataContext : DbContext
{
    protected readonly IConfiguration Configuration;

    public DataContext(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        // connect to mysql with connection string from app settings
        var connectionString = Configuration.GetConnectionString("ApiDatabase");
        var serverVersion = new MySqlServerVersion(new Version(5, 0, 25));
        var loggerFactory = LoggerFactory.Create(builder => {
            builder.AddConsole();
        });
        options
            .UseMySql(connectionString, serverVersion)
            .UseLoggerFactory(loggerFactory)
            .EnableSensitiveDataLogging()
            .UseSnakeCaseNamingConvention();
    }

    public DbSet<User> Users { get; set; }
}
