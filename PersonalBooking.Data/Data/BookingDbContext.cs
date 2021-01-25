using Microsoft.EntityFrameworkCore;
using PersonalBooking.Data.Models;

namespace PersonalBooking.Data.Data
{
    public class BookingDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Operation> Operations { get; set; }

        public BookingDbContext(DbContextOptions<BookingDbContext> options) : base(options)
        {
        }

    }
}
