using NewsCmsProject.Models.Dto.App;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace NewsCmsProject.Models.Dto
{
    public class HomeNews
    {
        public MainHomeNews[] ListHomeNews { get; set; }
        public IEnumerable<MainNewsCard> ListNewsCard { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
    }
    public class ListNews
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public IEnumerable<MainNewsCard> ListNewsCard { get; set; }
        public int PageCount { get; set; }
        public int CurrentPage { get; set; }
        public string GetTitle() => Regex.Replace(Title, "<.*?>", string.Empty);
    }
    public class MainHomeNews
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
        public int CountComments { get; set; }
        public string GetUrlTitle()
        {
            return Title.Replace(" ", "-");
        }
    }
    public class MainNewsCard
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string GroupTitle { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CountComments { get; set; }
        public string Summary { get; set; }
        public string GetUrlTitle() => Title.Replace(" ", "-");
    }
}