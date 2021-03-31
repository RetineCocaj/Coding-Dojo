using System;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public Customer Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public Product Product { get; set; }
        [Required]
        public int ProductId { get; set; }
    }
}