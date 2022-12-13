using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsCmsProject.Models.Entities
{
    public class FromTheWeb : BaseEntity
    {
        [DisplayName("عنوان خبر")]
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [MinLength(8, ErrorMessage = "{0} حداقل شامل 8 کارکتر است")]
        [MaxLength(150, ErrorMessage = "{0} حداکثر شامل 150 کارکتر است")]
        public string Title { get; set; } = string.Empty;
        [DisplayName("لینک خبر")]
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [Url(ErrorMessage = "لطفاً {0} معتبر وارد کنید")]
        public string Url { get; set; } = string.Empty;
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        [DisplayName("کاربر")]
        public virtual User User { get; set; }
    }
}