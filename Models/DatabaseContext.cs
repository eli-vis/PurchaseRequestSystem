using Microsoft.EntityFrameworkCore;

namespace PRS_Project.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Requests> Requests { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vendors> Vendors { get; set; }
        public DbSet<RequestLine> RequestLines { get; set; }

        public DatabaseContext()
        { }

        public DatabaseContext(DbContextOptions options) : base(options)
        { }
    }
}
