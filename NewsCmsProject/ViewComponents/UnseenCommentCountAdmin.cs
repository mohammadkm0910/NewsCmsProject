using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NewsCmsProject.Models.Contexts;
using NewsCmsProject.Models.Entities;

namespace NewsCmsProject.ViewComponents
{
    public class UnseenCommentCountAdmin : ViewComponent
    {
        private readonly DatabaseContext _db;

        public UnseenCommentCountAdmin(DatabaseContext context)
        {
            _db = context;
        }
        public IViewComponentResult Invoke() {
            var count = _db.Comments.Where(c => c.Status == CommentStatus.Unseen).Count();
            return View(count);
        }
    }
}