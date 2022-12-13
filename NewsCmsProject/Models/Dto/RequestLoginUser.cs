using System.ComponentModel;

namespace NewsCmsProject.Models.Dto
{
    public class RequestLoginUser
    {
        [DisplayName("پست الکترونیک")]
        public string Email { get; set; }
        [DisplayName("رمز عبور")]
        public string Password { get; set; }
        public bool IsRememberMe { get; set; }
    }
}
