using System;
using System.Collections.Generic;

namespace TheWall.Models
{
    public class Message
    {
        public int MessageId { get; set; }
        public string MessageText { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    
        public int UserId { get; set; }
        public List<Comment> Comments { get; set; }
        public User User { get; set; }
    }
}