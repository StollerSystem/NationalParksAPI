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
                  new NationalPark { NationalParkId = 2, NationalParkName = "Sequoia", NationalParkDescription = "test", NationalParkLocation = "California", DateEstablished = "September 25, 1890", NationalParkArea = 404062.63, AnnualVisitors = 1246053 },  
                  new NationalPark { NationalParkId = 3, NationalParkName = "Yosemite", NationalParkDescription = "test", NationalParkLocation = "California", DateEstablished = "October 1, 1890", NationalParkArea = 761747.50, AnnualVisitors = 4422861 },
                  new NationalPark { NationalParkId = 4, NationalParkName = "Mount Rainier", NationalParkDescription = "test", NationalParkLocation = "Washington", DateEstablished = "March 2, 1899", NationalParkArea = 236381.64, AnnualVisitors = 1501621 },
                  new NationalPark { NationalParkId = 5, NationalParkName = "Crater Lake", NationalParkDescription = "test", NationalParkLocation = "Oregon Lake", DateEstablished = "May 22, 1902", NationalParkArea = 236381.64, AnnualVisitors = 704512 }                      
              );

          builder.Entity<StatePark>()
              .HasData(
                  new StatePark { StateParkId = 1, StateParkName = "Goose Lake", StateParkDescription = "test", State = "Oregon"}, 
                  new StatePark { StateParkId = 2, StateParkName = "Smith Rock", StateParkDescription = "test", State = "Oregon"},
                  new StatePark { StateParkId = 3, StateParkName = "The Cove Palisades", StateParkDescription = "test", State = "Oregon"},
                  new StatePark { StateParkId = 4, StateParkName = "Cape Lookout", StateParkDescription = "test", State = "Oregon"},
                  new StatePark { StateParkId = 5, StateParkName = "Oswald West", StateParkDescription = "test", State = "Oregon"}
                   
                  
              );
        }
    }
}