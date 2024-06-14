using WebMvcDockerTest.Models;

namespace WebMvcDockerTest.Interfaces
{
    public interface IRepository
    {
        IEnumerable<Product> Products { get; }
    }
}