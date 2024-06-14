using Microsoft.EntityFrameworkCore;
using WebMvcDockerTest.Models;

namespace WebMvcDockerTest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
} 