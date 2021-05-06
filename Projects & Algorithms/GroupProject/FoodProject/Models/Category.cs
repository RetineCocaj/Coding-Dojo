using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodProject.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required]
        public string Name { get; set; }
        public ICollection<FoodItem> FoodItems { get; set; }

    }
}