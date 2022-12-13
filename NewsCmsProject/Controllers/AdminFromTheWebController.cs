using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NewsCmsProject.Models.Contexts;
using NewsCmsProject.Models.Entities;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using NewsCmsProject.Extensions;
using NewsCmsProject.Models;

namespace NewsCmsProject.Controllers
{
    [Authorize(Roles = nameof(UserPermission.Admin))]
    public class AdminFromTheWebController : Controller
    {
        private readonly DatabaseContext _db;

        public AdminFromTheWebController(DatabaseContext context)
        {
            _db = context;
        }
        [Route("Admin/FromTheWeb")]
        public  IActionResult Index()
        {
            var result = _db.FromTheWebs.Include(f => f.User).OrderByDescending(f => f.Id);
            return View(result);
        }
        [Route("Admin/FromTheWeb/Show/{id:int}")]
        public async Task<IActionResult> Show(int id)
        {
            var result = await _db.FromTheWebs
                .Include(f => f.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (result == null) return NotFound();
            return View(result);
        }
        [Route("Admin/FromTheWeb/Create")]
        public IActionResult Create()
        {
            return View();
        }
        [Route("Admin/FromTheWeb/Create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Title,Url")] FromTheWeb fromTheWeb)
        {
            var userId = User?.Identity?.GetId() ?? 0;
            var user = await _db.Users.FindAsync(userId);
            if (user == null) return RedirectToAction(nameof(Index));
            if (!ModelState.IsValid) return View(fromTheWeb);
            var theFrom = new FromTheWeb
            {
                Title = fromTheWeb.Title,
                Url = WebUtility.UrlDecode(fromTheWeb.Url),
                UserId = userId,
                User = user
            };
            _db.Add(theFrom);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Route("Admin/FromTheWeb/Edit/{id:int}")]
        public async Task<IActionResult> Edit(int id)
        {
            var fromTheWeb = await _db.FromTheWebs.FindAsync(id);
            if (fromTheWeb == null) return NotFound();
            return View(fromTheWeb);
        }
        [Route("Admin/FromTheWeb/Edit/{id:int}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Title,Url")] FromTheWeb fromTheWeb)
        {
            var userId = User?.Identity?.GetId() ?? 0;
            var user = await _db.Users.FindAsync(userId);
            if (user == null) return RedirectToAction(nameof(Index));
            var theFrom = await _db.FromTheWebs.FindAsync(id);
            if (theFrom == null) return NotFound();
            if (!ModelState.IsValid) return View(fromTheWeb);
            theFrom.Title = fromTheWeb.Title;
            theFrom.Url = fromTheWeb.Url;
            theFrom.UpdatedAt = DateTime.Now;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [Route("Admin/FromTheWeb/Destroy")]
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> Destroy(int id)
        {
            var theFrom = await _db.FromTheWebs.FindAsync(id);
            if (theFrom == null)
            {
                return Json(new ResultDto { IsSuccess = false, Message = "خبر یافت نشد!!" });
            }
            _db.Entry(theFrom).State = EntityState.Deleted;
            await _db.SaveChangesAsync();
            return Json(new ResultDto { IsSuccess = true, Message = "خبر با موفقیت حذف شد" });
        }
    }
}
