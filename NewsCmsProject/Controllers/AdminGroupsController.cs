using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsCmsProject.Models;
using NewsCmsProject.Models.Contexts;
using NewsCmsProject.Models.Entities;
using System;
using System.Data;
using System.Threading.Tasks;

namespace NewsCmsProject.Controllers
{
    [Authorize(Roles = nameof(UserPermission.Admin))]
    public class AdminGroupsController : Controller
    {
        private readonly DatabaseContext _db;

        public AdminGroupsController(DatabaseContext context)
        {
            _db = context;
        }
        [HttpGet("Admin/Groups", Name = "Admin.Groups")]
        public IActionResult Index()
        {
            return View(_db.Groups);
        }
        [HttpGet("Admin/Groups/Create", Name = "Admin.Groups.Create")]
        public IActionResult Create()
        {
            return PartialView();
        }
        [HttpPost("Admin/Groups/Create", Name = "Admin.Groups.Create")]
        public async Task<IActionResult> Create(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                return Json(new ResultDto { IsSuccess = false, Message = "عنوان گروه خالی است!!" });
            }
            var newTitle = title.Trim();
            if (newTitle.Length < 4 || newTitle.Length > 80)
            {
                return Json(new ResultDto { IsSuccess = false, Message = "عنوان گروه بین 4 تا 80 کارکتر است!" });
            }
            var group = new Group { Title = newTitle };
            await _db.Groups.AddAsync(group);
            await _db.SaveChangesAsync();
            return Json(new ResultDto { IsSuccess = true, Message = "گروه با موفقیت اضافه شد" });
        }
        [HttpGet("Admin/Groups/Edit/{id}", Name = "Admin.Groups.Edit")]
        public async Task<IActionResult> Edit(int id)
        {
            var group = await _db.Groups.FindAsync(id);
            if (group == null) return NotFound();
            return PartialView(group);
        }
        [HttpPost("Admin/Groups/Edit/{id}", Name = "Admin.Groups.Edit")]
        public async Task<IActionResult> Edit(int id, string title)
        {
            var group = await _db.Groups.FindAsync(id);
            if (group == null)
            {
                return Json(new ResultDto { IsSuccess = false, Message = "گروه یافت نشد!!" });
            }
            var newTitle = title.Trim();
            if (group.Title == newTitle)
            {
                return Json(new ResultDto { IsSuccess = false, Message = "عنوان گروه تغییری نکرده!" });
            }
            if (string.IsNullOrEmpty(title))
            {
                return Json(new ResultDto { IsSuccess = false, Message = "عنوان گروه خالی است!!" });
            }
            if (newTitle.Length < 4 || newTitle.Length > 80)
            {
                return Json(new ResultDto { IsSuccess = false, Message = "عنوان گروه بین 4 تا 80 کارکتر است!" });
            }
            group.Title = newTitle;
            group.UpdatedAt = DateTime.Now;
            await _db.SaveChangesAsync();
            return Json(new ResultDto { IsSuccess = true, Message = "گروه با موفقیت ویرایش شد" });
        }
        [HttpGet("Admin/Groups/Show/{id}", Name = "Admin.Groups.Show")]
        public async Task<IActionResult> Show(int id)
        {
            var group = await _db.Groups.FindAsync(id);
            if (group == null) return NotFound();
            return PartialView(group);
        }
        [HttpPost("Admin/Groups/Destroy", Name = "Admin.Groups.Destroy")]
        public async Task<IActionResult> Destroy(int id)
        {
            var group = await _db.Groups.FindAsync(id);
            if (group == null)
            {
                return Json(new ResultDto { IsSuccess = false, Message = "گروه یافت نشد!!" });
            }
            _db.Entry(group).State = EntityState.Deleted;
            await _db.SaveChangesAsync();
            return Json(new ResultDto { IsSuccess = true, Message = "گروه با موفقیت حذف شد" });
        }
    }
}