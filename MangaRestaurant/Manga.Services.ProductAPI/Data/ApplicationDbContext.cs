using Manga.Services.ProductAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace Manga.Services.ProductAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
