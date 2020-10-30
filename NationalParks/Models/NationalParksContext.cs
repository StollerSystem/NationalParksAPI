using Microsoft.EntityFrameworkCore;

namespace NationalParks.Models
{
    public class NationalParksContext : DbContext
    {
        public NationalParksContext(DbContextOptions<NationalParksContext> options)
            : base(options)
        {
        }

        public DbSet<Park> Parks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<Park>()
              .HasData(
                  new Park { ParkId = 1, ParkName = "YellowStone", ParkDescription = "test", ParkLocation = "Wyoming, Montana, Idaha", DateEstablished = "March 1, 1872", ParkArea = 2219790.71, AnnualVisitors = 4020288 },
                   new Park { ParkId = 1, ParkName = "Sequoia", ParkDescription = "test", ParkLocation = "California", DateEstablished = "September 25, 1890", ParkArea = 404062.63, AnnualVisitors = 1246053 }
                  
              );
        }
    }
}