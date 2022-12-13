using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NewsCmsProject.Extensions;
using NewsCmsProject.Models;
using NewsCmsProject.Models.Contexts;
using NewsCmsProject.Models.Dto;
using NewsCmsProject.Models.Entities;
using NewsCmsProject.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace NewsCmsProject.Controllers
{
    [Authorize(Roles = nameof(UserPermission.Admin))]
    public class AdminNewsController : Controller
    {
        private readonly DatabaseContext _db;
        private readonly IFileUpload _fileUpload;

        public AdminNewsController(DatabaseContext context, IWebHostEnvironment environment)
        {
            _db = context;
            _fileUpload = new FileUpload(environment);
        }
        [HttpGet("Admin/News", Name = "Admin.News")]
        public IActionResult Index()
        {
            var result = _db.News.Include(n => n.Group).Include(n => n.User).OrderByDescending(n => n.Id).Select(e => new DetailNews
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
            return View(result);
        }
        [HttpGet("Admin/News/Create", Name = "Admin.News.Create")]
        public IActionResult Create()
        {
            ViewBag.Groups = new SelectList(_db.Groups.OrderByDescending(g => g.Id), "Id", "Title");
            return View();
        }
        [HttpPost("Admin/News/Create", Name = "Admin.News.Create")]
        public async Task<IActionResult> Create([Bind("GroupId,Title,Summary,Body,Image,Shortcut,Status,IsMainPage")] RequestAddNews request)
        {
            var group = await _db.Groups.FindAsync(request.GroupId);
            var userId = User.Identity.GetId();
            var user = await _db.Users.FindAsync(userId);
            if (group == null)
            {
                TempData["Message"] = "گروه مورد ثبت شده برای خبر وجود ندارد!";
                return RedirectToRoute("Admin.News.Create");
            }
            if (user == null)
            {
                TempData["Message"] = "کاربر معتبری برای ثبت خبر وجود ندارد!";
                return RedirectToRoute("Admin.News.Create");
            }
            if (ModelState.IsValid)
            {
                var file = await _fileUpload.UploadFile(request.Image);
                var news = new TheNews
                {
                    Title = request.Title,
                    Summary = request.Summary,
                    Body = request.Body,
                    UserId = userId.Value,
                    GroupId = group.Id,
                    Shortcut = request.Shortcut,
                    IsMainPage = request.IsMainPage,
                    Status = request.Status,
                    Group = group,
                    User = user
                };
                if (file.IsSuccess) news.Image = file.Message;
                await _db.News.AddAsync(news);
                await _db.SaveChangesAsync();
                TempData["Message"] = "خبر با موفقیت اضافه شد!";
                return RedirectToRoute("Admin.News");
            }
            return RedirectToRoute("Admin.News.Create");
        }
        [HttpGet("Admin/News/Edit/{id}", Name = "Admin.News.Edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var news = await _db.News.FindAsync(id);
            if (news == null) return NotFound();
            ViewBag.Groups = new SelectList(_db.Groups.OrderByDescending(g => g.Id), "Id", "Title");
            var request = new RequestAddNews
            {
                GroupId = news.GroupId,
                Title = news.Title,
                Summary = news.Summary,
                Body = news.Body,
                Shortcut = news.Shortcut,
                Status = news.Status,
                IsMainPage = news.IsMainPage,
                ImageName = news.Image
            };
            return View(request);
        }
        [HttpPost("Admin/News/Edit/{id}", Name = "Admin.News.Edit")]
        public async Task<IActionResult> Edit(int id, [Bind("GroupId,Title,Summary,Body,Image,Shortcut,Status,IsMainPage")] RequestAddNews request)
        {
            var news = await _db.News.FindAsync(id);
            if (news == null) return NotFound();
            var group = await _db.Groups.FindAsync(request.GroupId);
            var userId = User.Identity.GetId();
            var user = await _db.Users.FindAsync(userId);
            if (group == null)
            {
                TempData["Message"] = "گروه مورد ثبت شده برای خبر وجود ندارد!";
                return RedirectToRoute("Admin.News.Edit");
            }
            if (user == null)
            {
                TempData["Message"] = "کاربر معتبری برای ثبت خبر وجود ندارد!";
                return RedirectToRoute("Admin.News.Edit");
            }
            if (ModelState.IsValid)
            {
                news.GroupId = request.GroupId;
                news.Group = group;
                news.Title = request.Title;
                news.Summary = request.Summary;
                news.Body = request.Body;
                news.Shortcut = request.Shortcut;
                news.Status = request.Status;
                news.IsMainPage = request.IsMainPage;
                news.UpdatedAt = DateTime.Now;
                var file = await _fileUpload.UploadFile(request.Image, news.Image);
                if (file.IsSuccess) news.Image = file.Message;
                await _db.SaveChangesAsync();
                TempData["Message"] = "خبر با موفقیت ویرایش شد!";
                return RedirectToRoute("Admin.News");
            }
            return RedirectToRoute("Admin.News.Edit");
        }
        [HttpPost("Admin/News/Destroy", Name = "Admin.News.Destroy")]
        public async Task<IActionResult> Destroy(int id)
        {
            var news = await _db.News.FindAsync(id);
            if (news == null)
            {
                return Json(new ResultDto { IsSuccess = false, Message = "خبر مورد نظر یافت نشد!" });
            }
            _db.Entry(news).State = EntityState.Deleted;
            _fileUpload.RemoveImage(news.Image);
            await _db.SaveChangesAsync();
            return Json(new ResultDto { IsSuccess = true, Message = "خبر مورد نظر با موفقیت حذف شد!" });
        }
        [HttpGet("Admin/News/Show/{id}", Name = "Admin.News.Show")]
        public async Task<IActionResult> Show(int id)
        {
            var news = await _db.News.Include(n => n.Group).Include(n => n.User).FirstOrDefaultAsync(e => e.Id == id);
            if (news == null) return NotFound();
            var user = news.User;
            var adminNews = new DetailNews
            {
                Id = id,
                Image = news.Image,
                GroupTitle = news.Group.Title,
                Title = news.Title,
                Visit = news.Visit,
                IsMainNews = news.IsMainPage,
                Status = news.Status,
                Username = $"{user.Firstname} {user.Lastname}",
                CreatedAt = news.CreatedAt,
                UpdatedAt = news.UpdatedAt,
                Summary = news.Summary,
                Body = news.Body,
                Shortcut = news.Shortcut
            };
            return View(adminNews);
        }
    }
}