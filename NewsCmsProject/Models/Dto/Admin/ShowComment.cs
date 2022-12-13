using NewsCmsProject.Models.Entities;
using System;

namespace NewsCmsProject.Models.Dto.Admin
{
    public class ShowComment
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string NewsTitle { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public CommentStatus Status { get; set; }
        public string Body { get; set; } = string.Empty;
        public string GetStatusClass()
        {
            return Status switch
            {
                CommentStatus.Unseen => "btn btn-resize btn-warning",
                CommentStatus.Seen => "btn btn-resize btn-primary",
                CommentStatus.Approved => "btn btn-resize btn-success",
                _ => "btn btn-resize btn-info"
            };
        }
        public bool IsUnseen() => Status == CommentStatus.Unseen;
    }
}