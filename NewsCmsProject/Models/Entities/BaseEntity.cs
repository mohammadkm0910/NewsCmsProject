using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NewsCmsProject.Models.Entities
{
    public abstract class BaseEntity<TKey>
    {
        [Key]
        public TKey Id { get; set; }
        [DisplayName("تاریخ ایجاد")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        [DisplayName("تاریخ بروزرسانی")]
        public DateTime? UpdatedAt { get; set; }
    }
    public abstract class BaseEntity : BaseEntity<int>
    {
    }
}