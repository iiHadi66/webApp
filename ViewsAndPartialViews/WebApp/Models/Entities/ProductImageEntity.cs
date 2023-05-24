using Microsoft.EntityFrameworkCore;

namespace WebApp.Models.Entities;

[PrimaryKey("ProductId", "ImageId")]
public class ProductImageEntity
{
    public int ProductId { get; set; }
    public ProductEntity Product { get; set; } = null!;

    public int ImageId { get; set; }
    public ImageEntity Image { get; set; } = null!;
    public bool IsDefaultImage { get; set; }
}
