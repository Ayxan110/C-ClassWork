using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaleApp.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public ICollection<Photo> Photos { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string UserName { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string UserSurname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(7)]
        [MaxLength(30)]
        public string PhoneNumber { get; set; }
    }
}
