using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using TrendMachineAPI.Models;

namespace TrendMachineAPI.Models
{
    public class TrendMachineDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public TrendMachineDBContext(DbContextOptions<TrendMachineDBContext>options, IConfiguration configuration):base(options)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var connectionString = Configuration.GetConnectionString("gameinfoContext");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<GameInfo> gametrend { get; set; } = null!;
        //public DbSet<GameInfosss> gameinfos { get; set; } = null; 
    }
}
