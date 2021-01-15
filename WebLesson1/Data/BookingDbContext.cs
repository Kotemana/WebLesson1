using Microsoft.EntityFrameworkCore;
using WebLesson1.Models;

namespace WebLesson1.Data
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
