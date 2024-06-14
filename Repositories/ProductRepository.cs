using WebMvcDockerTest.Data;
using WebMvcDockerTest.Interfaces;
using WebMvcDockerTest.Models;

namespace WebMvcDockerTest.Repositories
{
    public class ProductRepository : IRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> Products => _context.Products;
    }
}
