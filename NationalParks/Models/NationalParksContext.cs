using Microsoft.EntityFrameworkCore;

namespace NationalParks.Models
{
    public class NationalParksContext : DbContext
    {
        public NationalParksContext(DbContextOptions<NationalParksContext> options)
            : base(options)
        {
        }

        public DbSet<NationalPark> NationalParks { get; set; }
        public DbSet<StatePark> StateParks { get; set; }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
          builder.Entity<NationalPark>()
              .HasData(
                  new NationalPark { NationalParkId = 1, NationalParkName = "YellowStone", NationalParkDescription = "test", NationalParkLocation = "Wyoming, Montana, Idaha", DateEstablished = "March 1, 1872", NationalParkArea = 2219790.71, AnnualVisitors = 4020288 },    
                  new NationalPark { NationalParkId = 2, NationalParkName = "Sequoia", NationalParkDescription = "test", NationalParkLocation = "California", DateEstablished = "September 25, 1890", NationalParkArea = 404062.63, AnnualVisitors = 1246053 }                  
              );

          builder.Entity<StatePark>()
              .HasData(
                  new StatePark { StateParkId = 1, StateParkName = "Goose Lake", StateParkDescription = "test", State = "Oregon"}, 
                  new StatePark { StateParkId = 2, StateParkName = "Smith Rock", StateParkDescription = "test", State = "Oregon"}
                   
                  
              );
        }
    }
}