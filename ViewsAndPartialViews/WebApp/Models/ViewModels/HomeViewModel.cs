using WebApp.Models.Entities;

namespace WebApp.Models.ViewModels
{
    internal class HomeViewModel
    {
        public List<ProductEntity>? NewProducts { get; set; }
        public List<ProductEntity>? PopularProducts { get; set; }
        public List<ProductEntity>? FeaturedProducts { get; set; }
    }
}