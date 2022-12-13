using System.Collections.Generic;

namespace NewsCmsProject.Models.Dto
{
    public class SidebarNewsList
    {
        public IEnumerable<SidebarNews> MostCommentNews { get; set; }
        public IEnumerable<SidebarNews> MostVisitedNews { get; set; }
        public IEnumerable<FromTheWeb> ListFromTheWebs { get; set; }
    }
    public class SidebarNews
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int CountComments { get; set; }
    }
    public class FromTheWeb
    {
        public string Title { get; set; }
        public string Url { get; set; }
    }
}