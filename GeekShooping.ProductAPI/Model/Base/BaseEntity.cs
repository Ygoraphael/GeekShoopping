using System.ComponentModel.DataAnnotations;

namespace GeekShooping.ProductAPI.Model
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
