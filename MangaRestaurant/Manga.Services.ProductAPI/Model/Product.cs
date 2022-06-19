using System.ComponentModel.DataAnnotations;

namespace Manga.Services.ProductAPI.Model
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Range(1,1000)]
        public double Price { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }

        public string ImageURL { get; set; }
    }
}
