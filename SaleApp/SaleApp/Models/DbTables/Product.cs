using SaleApp.Models.DbTables;
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
        public string ProductName { get; set; }
        [Required]
        public int Price { get; set; }
        public ICollection<Photo> Photos { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Name { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        public string Surname { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(7)]
        [MaxLength(30)]
        public string PhoneNumber { get; set; }

        public Status Status { get; set; }

        public int VerificationCode { get; set; }
    }
}
