using Microsoft.AspNetCore.Http;
using NewsCmsProject.Models.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NewsCmsProject.Models.Dto
{
    public class RequestAddNews
    {
        [DisplayName("گروه خبر")]
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        public int GroupId { get; set; }
        [DisplayName("عنوان خبر")]
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [MinLength(5, ErrorMessage = "{0} حداقل شامل 5 کارکتر است")]
        [MaxLength(120, ErrorMessage = "{0} حداکثر شامل 120 کارکتر است")]
        public string Title { get; set; }
        [DisplayName("توضیح مختصر")]
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [MinLength(25, ErrorMessage = "{0} حداقل شامل 25 کارکتر است")]
        [MaxLength(440, ErrorMessage = "{0} حداکثر شامل 440 کارکتر است")]
        [DataType(DataType.MultilineText)]
        public string Summary { get; set; }
        [DisplayName("توضیح خبر")]
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [MinLength(50, ErrorMessage = "{0} حداقل شامل 50 کارکتر است")]
        [DataType(DataType.Html)]
        public string Body { get; set; }
        [DisplayName("تصویر خبر")]
        public IFormFile Image { get; set; }
        [DisplayName("میانبر خبر")]
        public string Shortcut { get; set; }
        [DisplayName("وضعیت خبر")]
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        public NewsStatus Status { get; set; }
        [DisplayName("صفحه اصلی")]
        public bool IsMainPage { get; set; }
        public string ImageName { get; set; } = null;
    }
}
