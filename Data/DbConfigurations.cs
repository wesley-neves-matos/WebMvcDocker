
using Microsoft.EntityFrameworkCore;
using WebMvcDockerTest.Models;

namespace WebMvcDockerTest.Data
{
    public static class DbConfigurations
    {
        public static void DbPopulation(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices.CreateScope())
            {
                // define the context
                AppDbContext context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

                // apply lastest migration
                context.Database.Migrate();

                if (!context.Products.Any())
                {
                    List<Product> products = new List<Product>();
                    for (int i = 0; i < 15; i++)
                    {
                        products.Add(new Product($"prod{i}", $"cat{i}", (new Random()).Next(100)));
                    }
                    context.Products.AddRange(products);
                    context.SaveChanges();
                }
            }
        }
        public static void ConfigureDb(this WebApplicationBuilder builder)
        {
            var host = builder.Configuration["DBHOST"] ?? "localhost";
            var port = builder.Configuration["DBPORT"] ?? "3306";
            var password = builder.Configuration["DBPASSWORD"] ?? "12345678";

            string connectionString = $"server={host};user=root;password={password};port={port};database=productsdb";

            System.Console.WriteLine($"String de conexão: {connectionString}");

            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        }
    }
}