
using System.ComponentModel.DataAnnotations;

namespace WebApi.Entities
{
    public class ProductModel
    {
        [Key]
        public long ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
