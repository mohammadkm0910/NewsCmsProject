using System.ComponentModel.DataAnnotations.Schema;

namespace NewsCmsProject.Models.Entities
{
    public class Comment : BaseEntity
    {
        public string Body { get; set; } = string.Empty;
        public int UserId { get; set; }
        public int NewsId { get; set; }
        public CommentStatus Status { get; set; } = CommentStatus.Unseen;
        [ForeignKey(nameof(NewsId))]
        public virtual TheNews TheNews { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
    }
    public enum CommentStatus
    {
        Unseen = 0,
        Seen = 1,
        Approved = 2
    }
}