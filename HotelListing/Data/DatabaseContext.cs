using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

namespace HotelListing.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions option):base (option)
        {

        }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Nigeria",
                    ShortName = "NIG",
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BHM",
                }, new Country
                {
                    Id = 3,
                    Name = "Ghana",
                    ShortName = "GHN",
                }
                );
            builder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "LIfeTIme Hotel and Suites",
                    Address = "Lagos",
                    CountryId = 1,
                    Rating = 4.5

                },
                new Hotel
                {
                    Id = 2,
                    Name = "Shege Hotel and Suites",
                    Address = "Ogun",
                    CountryId = 2,
                    Rating = 3.0

                },
                new Hotel
                {
                    Id = 3,
                    Name = "Femolala Hotel and Suites",
                    Address = "Abuja",
                    CountryId = 3,
                    Rating = 3.5

                });

        }


    }
}
