using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefsNDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId{ get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int ChefId { get; set; }
        public Chef Chef { get; set; }
        [Required]
        [Range(0, 5)]
        public int Tastiness { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Calories { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}