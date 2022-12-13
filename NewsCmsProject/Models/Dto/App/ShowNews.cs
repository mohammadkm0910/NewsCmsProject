using System;
using System.Collections.Generic;

namespace NewsCmsProject.Models.Dto.App
{
    public class ShowNews
    {
        public int Id { get; set; }
        public string GroupTitle { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Body { get; set; }
        public IEnumerable<ShowComment> Comments { get; set; }
    }
    public class ShowComment
    {
        public string Username { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}