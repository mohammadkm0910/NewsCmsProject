using System;
using System.Globalization;
using System.Text;

namespace NewsCmsProject.Extensions
{
    public static class DateExt
    {
        public static string ToSolar(this DateTime dt) {
            var pc = new PersianCalendar();
            var builder = new StringBuilder();
            builder.Append(pc.GetYear(dt) + "/").Append(pc.GetMonth(dt).ToString("00") + "/").Append(pc.GetDayOfMonth(dt).ToString("00") + " ")
                .Append(pc.GetHour(dt).ToString("00") + ":").Append(pc.GetMonth(dt).ToString("00") + ":")
                .Append(pc.GetSecond(dt).ToString("00")).Append(" " + dt.ToString("tt"));
            return builder.ToString();
        }
        public static string GetTimeAgo(this DateTime dt) {
            var ts = new TimeSpan(DateTime.UtcNow.Ticks - dt.Ticks);
            var seconds = Math.Abs(ts.TotalSeconds);
            var minutes = Math.Round(seconds / 60);
            var hours = Math.Round(seconds / 3600);
            var days = Math.Round(seconds / 86400);
            var weeks = Math.Round(seconds / 604800);
            var months = Math.Round(seconds / 2600640);
            var years = Math.Round(seconds / 31207680);
            if (seconds <= 60)
            {
                return "همین الان";
            }
            else if (minutes <= 60)
            {
                return minutes == 1 ? "یک دقیقه قبل" : $"{minutes} دقیقه قبل ";
            }
            else if (hours <= 24) {
                return hours == 1 ? "یک ساعت قبل" : $"{hours} ساعت قبل ";
            }
            else if (days <= 7) {
                return days == 1 ? "دیروز" : $"{days} روز قبل ";
            }
            else if (weeks <= 4.3) {
                return weeks == 1 ? "یک هفته قبل" : $"{weeks} هفته قبل ";
            }
            else if (months <= 12) {
                return months == 1 ? "یک ماه قبل" : $"{months} ماه قبل ";
            }
            else
            {
                return years == 1 ? "یک سال قبل" : $"{years} سال قبل ";
            }
        }
    }
}