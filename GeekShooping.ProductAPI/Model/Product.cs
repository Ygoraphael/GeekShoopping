using System.ComponentModel.DataAnnotations;

namespace GeekShooping.ProductAPI.Model
{
    public class Product : BaseEntity
    {
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        [Range(1,100000)]
        public decimal Price { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(300)]
        public string ImageURL { get; set; }

    }
}
