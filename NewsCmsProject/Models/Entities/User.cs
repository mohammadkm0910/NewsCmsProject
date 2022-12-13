using System.ComponentModel.DataAnnotations;

namespace NewsCmsProject.Models.Entities
{
    public class User : BaseEntity
    {
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public UserPermission Permission { get; set; } = UserPermission.User;
    }
    public enum UserPermission
    {
        User = 0,
        Admin = 1
    }
}