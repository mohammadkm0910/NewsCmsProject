using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NewsCmsProject.Models.Dto
{
    public class RequestRegisterUser
    {
        [DisplayName("نام کاربر")]
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [MinLength(3, ErrorMessage = "{0} حداقل شامل 3 کارکتر است")]
        [MaxLength(50, ErrorMessage = "{0} حداکثر شامل 50 کارکتر است")]
        public string Firstname { get; set; }
        [DisplayName("فامیل کاربر")]
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [MinLength(3, ErrorMessage = "{0} حداقل شامل 3 کارکتر است")]
        [MaxLength(50, ErrorMessage = "{0} حداکثر شامل 50 کارکتر است")]
        public string Lastname { get; set; }
        [DisplayName("پست الکترونیک")]
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [EmailAddress(ErrorMessage = "لطفاً {0} معتبری وارد کنید")]
        public string Email { get; set; }
        [DisplayName("رمز عبور")]
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [MinLength(8, ErrorMessage = "{0} حداقل شامل 8 کارکتر است")]
        [MaxLength(25, ErrorMessage = "{0} حداکثر شامل 25 کارکتر است")]
        public string Password { get; set; }
        [DisplayName("تکرار رمز عبور")]
        [Required(ErrorMessage = "لطفاً {0} را وارد کنید")]
        [Compare(nameof(Password), ErrorMessage = "{0} با رمز عبور برابر نیست")]
        public string RePassword { get; set; }
    }
}