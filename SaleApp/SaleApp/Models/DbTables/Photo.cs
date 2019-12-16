using System.ComponentModel.DataAnnotations;

namespace SaleApp.Models
{
    public class Photo
    {
        public int ID { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(600)]
        public string Name { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}