using NewsCmsProject.Models.Entities;
using System;

namespace NewsCmsProject.Models.Dto
{
    public class DetailNews
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string GroupTitle { get; set; }
        public string Title { get; set; }
        public int Visit { get; set; }
        public bool IsMainNews { get; set; }
        public NewsStatus Status { get; set; }
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; } = null;
        public string Summary { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public string Shortcut { get; set; } = null;
        public int CountComments { get; set; } = 0;
        public string GetStatusClass()
        {
            return Status switch
            {
                NewsStatus.Enable => "fas fa-eye",
                NewsStatus.Disable => "fas fa-eye-slash",
                _ => ""
            };
        }
        public string GetMainPageClass()
        {
            return IsMainNews ? "fas fa-check-square" : "fas fa-square";
        }
    }
}