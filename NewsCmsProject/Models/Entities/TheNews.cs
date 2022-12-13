using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace NewsCmsProject.Models.Entities
{
    public class TheNews : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public int Visit { get; set; } = 0;
        public int UserId { get; set; }
        public int GroupId { get; set; }
        [AllowNull]
        public string Shortcut { get; set; } = null;
        [AllowNull]
        public string Image { get; set; } = null;
        public NewsStatus Status { get; set; } = NewsStatus.Disable;
        public bool IsMainPage { get; set; } = false;
        [ForeignKey(nameof(GroupId))]
        public virtual Group Group { get; set; }
        [ForeignKey(nameof(UserId))]
        public virtual User User { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
    public enum NewsStatus
    {
        Disable = 0,
        Enable = 1
    }
}