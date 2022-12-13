using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NewsCmsProject.Extensions;
using NewsCmsProject.Models;
using NewsCmsProject.Models.Contexts;
using NewsCmsProject.Models.Dto;
using NewsCmsProject.Models.Dto.App;
using NewsCmsProject.Models.Entities;
using Newtonsoft.Json;
using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace NewsCmsProject.Controllers
{
    public class HomeController : Controller
    {
        private const int pageSize = 8;
        private readonly DatabaseContext _db;

        public HomeController(DatabaseContext context)
        {
            _db = context;
        }
        public async Task<IActionResult> Index(int page = 1)
        {
            var news = _db.News.Include(n => n.User).Include(n => n.Group).Include(n => n.Comments);
            var mainNews = news.Where(n => n.Status == NewsStatus.Enable && n.IsMainPage).Select(e => new MainHomeNews
            {
                Id = e.Id,
                Title = e.Title,
                Image = e.Image,
                Username = $"{e.User.Firstname} {e.User.Lastname}",
                CountComments = e.Comments.Count
            }).Take(6);
            var cardNews = news.Where(n => n.Status == NewsStatus.Enable).OrderByDescending(n => n.CreatedAt).Select(e => new MainNewsCard
            {
                Id = e.Id,
                GroupId = e.GroupId,
                GroupTitle = e.Group.Title,
                Title = e.Title,
                Image = e.Image,
                Username = $"{e.User.Firstname} {e.User.Lastname}",
                CreatedAt = e.CreatedAt,
                CountComments = e.Comments.Count,
                Summary = e.Summary
            });
            var rows = await cardNews.CountAsync();
            var pageCount = (int)Math.Ceiling((double)rows / pageSize);
            page = Math.Min(page, pageCount);
            page = Math.Max(page, 1);
            var homeNews = new HomeNews
            {
                ListHomeNews = await mainNews.ToArrayAsync(),
                ListNewsCard = cardNews.Skip((page - 1) * pageSize).Take(pageSize),
                PageCount = pageCount,
                CurrentPage = page
            };
            return View(homeNews);
        }
        [HttpGet("Home/Show/{id}/{title}", Name = "Home.Show")]
        public async Task<IActionResult> Show(int id, string title)
        {
            var news = await _db.News.Include(n => n.User).Include(n => n.Group)
                .FirstOrDefaultAsync(e => e.Id == id && e.Status == NewsStatus.Enable);
            var comments = _db.Comments.Where(c => c.NewsId == news.Id && c.Status == CommentStatus.Approved);
            if (news == null) return RedirectToAction(nameof(Index));
            var showNews = new ShowNews
            {
                Id = news.Id,
                Image = news.Image,
                GroupTitle = news.Group.Title,
                Title = news.Title,
                Username = $"{news.User.Firstname} {news.User.Lastname}",
                CreatedAt = news.CreatedAt,
                Body = news.Body,
                Comments = comments.OrderByDescending(c => c.CreatedAt).Select(c => new ShowComment
                {
                    Username = $"{c.User.Firstname} {c.User.Lastname}",
                    Body = c.Body,
                    CreatedAt = c.CreatedAt
                })
            };
            if (!HttpContext.IsRefreshingOrNull())
            {
                var visit = news.Visit;
                visit++;
                news.Visit = visit;
                await _db.SaveChangesAsync();
            }
            return View(showNews);
        }
        [HttpGet("Home/Group/{id}/{title}", Name = "Home.Group")]
        public async Task<IActionResult> Group(int id, string title, int page = 1)
        {
            var group = await _db.Groups.FindAsync(id);
            if (group == null) return NotFound();
            if (!group.Title.Equals(title)) return RedirectToAction(nameof(Index));
            var news = _db.News.Include(n => n.User).Include(n => n.Comments).Where(n => n.GroupId == id && n.Status == NewsStatus.Enable)
                .OrderByDescending(n => n.CreatedAt);
            if (news == null) return NotFound();
            var result = news.Select(n => new MainNewsCard
            {
                Id = n.Id,
                GroupId = group.Id,
                GroupTitle = group.Title,
                Title = n.Title,
                Image = n.Image,
                Username = $"{n.User.Firstname} {n.User.Lastname}",
                CreatedAt = DateTime.Now,
                CountComments = n.Comments.Count,
                Summary = n.Summary
            });
            var rows = await result.CountAsync();
            var pageCount = (int)Math.Ceiling((double)rows / pageSize);
            page = Math.Min(page, pageCount);
            page = Math.Max(page, 1);
            var listNews = new ListNews
            {
                Id = id,
                Title = title,
                ListNewsCard = result.Skip((page - 1) * pageSize).Take(pageSize),
                PageCount = pageCount,
                CurrentPage = page
            };
            return View(listNews);
        }
        [HttpGet("Home/News-List", Name = "Home.NewsList")]
        public async Task<IActionResult> NewsList(int page = 1)
        {
            var news = _db.News.Include(n => n.User).Include(n => n.Comments).Include(n => n.Group).Where(n => n.Status == NewsStatus.Enable)
                .OrderByDescending(n => n.CreatedAt);
            var result = news.Select(n => new MainNewsCard
            {
                Id = n.Id,
                GroupId = n.Group.Id,
                GroupTitle = n.Group.Title,
                Title = n.Title,
                Image = n.Image,
                Username = $"{n.User.Firstname} {n.User.Lastname}",
                CreatedAt = DateTime.Now,
                CountComments = n.Comments.Count,
                Summary = n.Summary
            });
            var rows = await result.CountAsync();
            var pageCount = (int)Math.Ceiling((double)rows / pageSize);
            page = Math.Min(page, pageCount);
            page = Math.Max(page, 1);
            var listNews = new ListNews
            {
                Title = "لیست اخبار",
                ListNewsCard = result.Skip((page - 1) * pageSize).Take(pageSize),
                PageCount = pageCount,
                CurrentPage = page
            };
            return View(listNews);
        }
        public async Task<IActionResult> Search(string q, int page = 1)
        {
            q ??= "";
            var news = _db.News.Include(n => n.User).Include(n => n.Comments).Include(n => n.Group).Where(
                n => n.Status == NewsStatus.Enable && (n.Summary.Contains(q) || n.Title.Contains(q) ||
                        n.Group.Title.Contains(q))
                ).Distinct();
            var result = news.Select(n => new MainNewsCard
            {
                Id = n.Id,
                GroupId = n.Group.Id,
                GroupTitle = n.Group.Title,
                Title = n.Title,
                Image = n.Image,
                Username = $"{n.User.Firstname} {n.User.Lastname}",
                CreatedAt = DateTime.Now,
                CountComments = n.Comments.Count,
                Summary = n.Summary
            });
            var rows = await result.CountAsync();
            var pageCount = (int)Math.Ceiling((double)rows / pageSize);
            page = Math.Min(page, pageCount);
            page = Math.Max(page, 1);
            var listNews = new ListNews
            {
                Title = $"نتیجه جست و جو: <em>{q}</em>",
                ListNewsCard = result.Skip((page - 1) * pageSize).Take(pageSize),
                PageCount = pageCount,
                CurrentPage = page
            };
            return View(listNews);
        }
        [HttpPost("Home/Comment-Store", Name = "Home.CommentStore")]
        public async Task<IActionResult> CommentStore(int newsId, string comment, bool accept)
        {
            var news = await _db.News.FirstOrDefaultAsync(n => n.Id == newsId && n.Status == NewsStatus.Enable);
            var user = await _db.Users.FindAsync(User.Identity.GetId() ?? 0);
            if (news == null || user == null) return NotFound();
            if (!accept) return Json(new ResultDto { IsSuccess = false, Message = "شما با قوانین سایت مخالفت کردید!" });
            if (string.IsNullOrEmpty(comment)) return Json(new ResultDto { IsSuccess = false, Message = "نظری وارد نشده!" });
            var newComment = comment.Trim();
            if (newComment.Length < 10 && newComment.Length > 500)
            {
                return Json(new ResultDto { IsSuccess = false, Message = "نظر وارد شده باید بین 10 تا 500 کارکتر باشد!" });
            }
            var dbComment = new Comment
            {
                Body = newComment,
                UserId = user.Id,
                NewsId = newsId,
                TheNews = news,
                User = user
            };
            await _db.Comments.AddAsync(dbComment);
            await _db.SaveChangesAsync();
            return Json(new ResultDto { IsSuccess = true, Message = "نظر با موفقیت ثبت شد!" });
        }
    }
}