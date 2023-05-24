namespace WebApp.Models.Entities;

public class ImageEntity
{
    public int Id { get; set; }
    public string ImageUrl { get; set; } = null!;
    public ICollection<ProductImageEntity> Products { get; set; } = new HashSet<ProductImageEntity>();
}
