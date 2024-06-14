using System.ComponentModel.DataAnnotations;

namespace WebMvcDockerTest.Models
{
    public class Product
    {
        [Display(Name = "Id")]
        public int ProductId { get; set; }

        [Display(Name = "Nome")]
        public string? Name { get; set; }

        [Display(Name = "Categoria")]
        public string? Category { get; set; }

        [Display(Name = "Preço")]
        public decimal Price { get; set; }

        public Product(string? name = null, string? category = null, decimal price = 0)
        {
            Name = name;
            Category = category;
            Price = price;
        }
    }
}