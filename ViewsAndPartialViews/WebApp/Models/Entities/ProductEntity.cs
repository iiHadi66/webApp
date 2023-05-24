using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.Models.Entities;
public class ProductEntity
{
    public int Id { get; set; }
    public string? ProductName { get; set; }
    public string? Ingress { get; set; }
    public string? Description { get; set; } 

    [Column(TypeName = "money")]
    public decimal Price { get; set; } 

    public ICollection<ProductCategoryEntity> Categories { get; set; } = new HashSet<ProductCategoryEntity>();
    public ICollection<ProductImageEntity> Images { get; set; } = new HashSet<ProductImageEntity>();

}
