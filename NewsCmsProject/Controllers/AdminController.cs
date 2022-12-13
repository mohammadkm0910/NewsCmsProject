using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsCmsProject.Extensions;
using NewsCmsProject.Models;
using NewsCmsProject.Models.Contexts;
using NewsCmsProject.Models.Dto;
using NewsCmsProject.Models.Dto.Admin;
using NewsCmsProject.Models.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NewsCmsProject.Controllers
{
    [Authorize(Roles = nameof(UserPermission.Admin))]
    public class AdminController : Controller
    {
        private readonly DatabaseContext _db;

        public AdminController(DatabaseContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            var news = _db.News;
            var comments = _db.Comments;
            var result = new DashboardAdmin
            {
                NewsDisplayedCount = news.Count(n => n.Status == NewsStatus.Enable),
                NewsCount = news.Count(),
                CommentApprovedCount = comments.Count(c => c.Status == CommentStatus.Approved),
                GroupNewsCount = _db.Groups.Count(),
                CommentCount = comments.Count(),
                UserSiteCount = _db.Users.Count()
            };
            return View(result);
        }
        public IActionResult ListUsers()
        {
            return View(_db.Users);
        }
        public async Task<IActionResult> ChangeUserPermission(int id)
        {
            var authId = User?.Identity?.GetId();
            if (authId == id)
            {
                TempData["Object"] = ResultDto.CreateJson(false, "کاربر ثبت نام شده امکان تغییر وضعیت ندارد!");
                return RedirectToAction(nameof(ListUsers));
            }
            var user = await _db.Users.FindAsync(id);
            if (user == null)
            {
                TempData["Object"] = ResultDto.CreateJson(false, "کاربر مورد نظر یافت نشد!");
                return RedirectToAction(nameof(ListUsers));
            }
            user.Permission = (user.Permission == UserPermission.User) ? UserPermission.Admin : UserPermission.User;
            await _db.SaveChangesAsync();
            TempData["Object"] = ResultDto.CreateJson(true, "سطح دسترسی کاربر با موفقیت تغییر کرد");
            return RedirectToAction(nameof(ListUsers));
        }
        [HttpGet("Admin/Comment-Manager", Name = "Admin.CommentManager")]
        public IActionResult CommentManager()
        {
            var comments = _db.Comments.Include(c => c.User).Include(c => c.TheNews).OrderByDescending(c => c.CreatedAt).Select(e => new ShowComment
            {
                Id = e.Id,
                Username = $"{e.User.Firstname} {e.User.Lastname}",
                NewsTitle = e.TheNews.Title,
                CreatedAt = e.CreatedAt,
                UpdatedAt = e.UpdatedAt,
                Status = e.Status
            });
            return View(comments);
        }
        public async Task<IActionResult> SeenAllComment()
        {
            if (!HttpContext.IsAjaxRequestOrNull()) return RedirectToRoute("Admin.CommentManager");
            var comments = _db.Comments.Where(c => c.Status == CommentStatus.Unseen);
            if (!comments.Any())
            {
                return Json(new ResultDto { IsSuccess = false, Message = "نظرات غیر خوانایی یافت نشد" + "!" });
            }
            foreach (var comment in comments)
            {
                comment.Status = CommentStatus.Seen;
            }
            await _db.SaveChangesAsync();
            return Json(new ResultDto { IsSuccess = true, Message = "تمامی نظرات خوانا شدند" + "!" });
        }
        [HttpGet("Admin/Edit-Comment/{id}", Name = "Admin.EditComment")]
        public async Task<IActionResult> EditComment(int id)
        {
            if (!HttpContext.IsAjaxRequestOrNull()) return RedirectToRoute("Admin.CommentManager");
            var comment = await _db.Comments.FirstOrDefaultAsync(c => c.Id == id && c.Status != CommentStatus.Unseen);
            return PartialView(comment);
        }
        [HttpPost("Admin/Edit-Comment/{id}", Name = "Admin.EditComment")]
        public async Task<IActionResult> EditComment(int id, string body)
        {
            var comment = await _db.Comments.FindAsync(id);
            if (comment == null) return Json(new ResultDto { IsSuccess = false, Message = "نظر یافت نشد!" });
            if (string.IsNullOrEmpty(body))
            {
                return Json(new ResultDto { IsSuccess = false, Message = "نظری وارد نشده است!" });
            }
            if (string.IsNullOrEmpty(body))
            {
                return Json(new ResultDto { IsSuccess = false, Message = "نظری وارد نشده است!" });
            }
            var newBody = body.Trim();
            if (newBody.Length < 10 && newBody.Length > 500)
            {
                return Json(new ResultDto { IsSuccess = false, Message = "نظر وارد شده باید بین 10 تا 500 کارکتر باشد!" });
            }
            if (comment.Body.Equals(newBody))
            {
                return Json(new ResultDto { IsSuccess = false, Message = "نظر وارد شده با نظر موجود یکسان است!" });
            }
            comment.Body = body;
            comment.UpdatedAt = DateTime.Now;
            await _db.SaveChangesAsync();
            return Json(new ResultDto { IsSuccess = true, Message = "متن خبر با موفقیت تغییر کرد!" });
        }
        [HttpGet("Admin/Change-Status-Comment/{id}", Name = "Admin.ChangeStatusComment")]
        public async Task<IActionResult> ChangeStatusComment(int id)
        {
            if (!HttpContext.IsAjaxRequestOrNull()) return RedirectToRoute("Admin.CommentManager");
            var comment = await _db.Comments.FindAsync(id);
            if (comment == null) return Json(new ResultDto<int> { IsSuccess = false, Message = "نظر یافت نشد!", Data = 0 });
            string message;
            switch (comment.Status)
            {
                case CommentStatus.Unseen:
                    comment.Status = CommentStatus.Seen;
                    await _db.SaveChangesAsync();
                    message = "btn btn-resize btn-primary";
                    break;
                case CommentStatus.Seen:
                    comment.Status = CommentStatus.Approved;
                    await _db.SaveChangesAsync();
                    message = "btn btn-resize btn-success";
                    break;
                case CommentStatus.Approved:
                    comment.Status = CommentStatus.Unseen;
                    await _db.SaveChangesAsync();
                    message = "btn btn-resize btn-warning";
                    break;
                default:
                    comment.Status = CommentStatus.Unseen;
                    await _db.SaveChangesAsync();
                    message = "btn btn-resize btn-warning";
                    break;
            }
            int count = await _db.Comments.CountAsync(c => c.Status == CommentStatus.Unseen);
            return Json(new ResultDto<int> { IsSuccess = true, Message = message, Data = count });
        }
        [HttpGet("Admin/Show-Comment/{id}", Name = "Admin.ShowComment")]
        public async Task<IActionResult> ShowComment(int id)
        {
            var comment = await _db.Comments.Include(c => c.User).Include(c => c.TheNews).FirstOrDefaultAsync(c => c.Id == id);
            if (comment == null) return NotFound();
            var showComment = new ShowComment
            {
                Id = comment.Id,
                Username = $"{comment.User.Firstname} {comment.User.Lastname}",
                NewsTitle = comment.TheNews.Title,
                CreatedAt = comment.CreatedAt,
                UpdatedAt = comment.UpdatedAt,
                Status = comment.Status,
                Body = comment.Body
            };
            return View(showComment);
        }
        [HttpPost("Admin/Destroy-Comment", Name = "Admin.DestroyComment")]
        public async Task<IActionResult> DestroyComment(int id)
        {
            if (!HttpContext.IsAjaxRequestOrNull()) return RedirectToRoute("Admin.CommentManager");
            var comment = await _db.Comments.FindAsync(id);
            if (comment == null) return Json(new ResultDto { IsSuccess = false, Message = "نظر یافت نشد!" });
            _db.Entry(comment).State = EntityState.Deleted;
            await _db.SaveChangesAsync();
            return Json(new ResultDto { IsSuccess = true, Message = "نظر با موفقیت حذف شد!" });
        }
        public IActionResult Search(string url, string q)
        {
            q ??= "";
            if (url == "news")
            {
                var result = _db.News.Include(n => n.Group).Include(n => n.User).Where(n => n.Title.Contains(q) || n.Summary.Contains(q))
                    .Distinct().Select(e => new DetailNews
                    {
                        Id = e.Id,
                        Image = e.Image,
                        GroupTitle = e.Group.Title,
                        Title = e.Title,
                        Visit = e.Visit,
                        IsMainNews = e.IsMainPage,
                        Status = e.Status,
                        Username = $"{e.User.Firstname} {e.User.Lastname}",
                        CreatedAt = e.CreatedAt
                    });
                return View("~/Views/AdminNews/Index.cshtml", result);
            }
            else if (url == "groups")
            {
                var result = _db.Groups.Where(g => g.Title.Contains(q)).Distinct();
                return View("~/Views/AdminGroups/Index.cshtml", result);
            }
            else if (url == "list-user")
            {
                var result = _db.Users.Where(u => u.Firstname.Contains(q) || u.Lastname.Contains(q) || u.Email.Contains(q)).Distinct();
                return View("~/Views/Admin/ListUsers.cshtml", result);
            }
            else if (url == "comment-manager")
            {
                var result = _db.Comments.Include(c => c.User).Include(c => c.TheNews).Where(c => c.Body.Contains(q))
                    .Distinct().Select(e => new ShowComment
                {
                    Id = e.Id,
                    Username = $"{e.User.Firstname} {e.User.Lastname}",
                    NewsTitle = e.TheNews.Title,
                    CreatedAt = e.CreatedAt,
                    UpdatedAt = e.UpdatedAt,
                    Status = e.Status
                });
                return View("~/Views/Admin/CommentManager.cshtml", result);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}