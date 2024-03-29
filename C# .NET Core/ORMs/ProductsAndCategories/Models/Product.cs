using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
namespace ProductsAndCategories.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(0.00, Single.MaxValue)]
        public double Price { get; set; }   
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Association> Associations { get; set; }
    }
}