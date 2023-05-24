using Microsoft.EntityFrameworkCore;


namespace WebApp.Models.Entities;

[PrimaryKey("ProductId", "CategoryId")]
public class ProductCategoryEntity
{
    public int ProductId { get; set; }
    public ProductEntity Product { get; set; } = null!;

    public int CategoryId { get; set; }
    public CategoryEntity Category { get; set; } = null!;
}
