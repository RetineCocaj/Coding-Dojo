using System;
namespace TheWall.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        public int MessageId { get; set; }
        public Message Message { get; set; }
        public User User { get; set; }
    }
}