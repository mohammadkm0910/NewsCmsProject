using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsCmsProject.Models.Contexts;
using NewsCmsProject.Models.Dto;
using NewsCmsProject.Models.Entities;
using FromTheWeb = NewsCmsProject.Models.Dto.FromTheWeb;

namespace NewsCmsProject.ViewComponents
{
    public class SidebarAppComponent : ViewComponent
    {
        private readonly DatabaseContext _db;

        public SidebarAppComponent(DatabaseContext context)
        {
            _db = context;
        }
        public IViewComponentResult Invoke()
        {
            var news = _db.News.Include(n => n.Comments).Where(n => n.Status == NewsStatus.Enable);
            IEnumerable<SidebarNews> newsMost = news.OrderByDescending(n => n.Comments.Count).Take(5).Select(n => new SidebarNews
            {
                Id = n.Id,
                Title = n.Title,
                Image = n.Image,
                CountComments = n.Comments.Count
            });
            IEnumerable<SidebarNews> newsMostVisit = news.OrderByDescending(n => n.Visit).Take(5).Select(n => new SidebarNews
            {
                Id = n.Id,
                Title = n.Title,
                Image = n.Image,
            });
            IEnumerable<FromTheWeb> listFromTheWebs = _db.FromTheWebs.OrderByDescending(f => f.Id).Select(f => new FromTheWeb
            {
                Title = f.Title,
                Url = f.Url
            });
            var result = new SidebarNewsList
            {
                MostCommentNews = newsMost.Where(s => s.CountComments > 0),
                MostVisitedNews = newsMostVisit,
                ListFromTheWebs = listFromTheWebs
            };
            return View(result);
        }
    }
}