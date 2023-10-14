using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace coreEfMvc.Models;

[Table("Product")]
public partial class Product
{
    [Key]
    public int Id { get; set; }

    [StringLength(70)]
    public string? Name { get; set; }

    public string? Description { get; set; }

    [Column(TypeName = "money")]
    public decimal? Cost { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    [StringLength(500)]
    public string? ImageUrl { get; set; }

    public int? CategoryId { get; set; }

    [ForeignKey("CategoryId")]
    [InverseProperty("Products")]
    public virtual Category? Category { get; set; }
}
