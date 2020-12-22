using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AllupPractice.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        public double ExTax { get; set; }
        [Required]
        public double Rate { get; set; }
        [Required]
        public string ProductCode { get; set; }
        public double Discount { get; set; }
        [Required]
        public int SaleCount { get; set; }
        [Required]
        public int CurrentCount { get; set; }
        public string Tags { get; set; }
        public string Brand { get; set; }
        public bool IsDeleted { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; } 
    }
}
