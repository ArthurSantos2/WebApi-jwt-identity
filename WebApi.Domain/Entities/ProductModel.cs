
using System.ComponentModel.DataAnnotations;

namespace WebApi.Domain.Entities
{
    public class ProductModel
    {
        [Key]
        public long ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
