using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace NewsCmsProject.Extensions
{
    public static class HttpContextExt
    {
        public static bool IsMicrosoftEdge(this HttpContext context)
        {
            string userAgent = context?.Request.Headers["User-Agent"];
            return !string.IsNullOrEmpty(userAgent) && userAgent.Contains("Edg");
        }
        public static bool IsInternetExplore(this HttpContext context)
        {
            string userAgent = context?.Request.Headers["User-Agent"];
            return !string.IsNullOrEmpty(userAgent) && userAgent.Contains("Trident/7.0; rv:11.0");
        }
        public static string ActivePage(this HttpContext context, string route, bool endCheckUrl = false, string @class = "active")
        {
            var url = context?.Request.GetDisplayUrl()?.ToLower();
            if (string.IsNullOrEmpty(url)) return string.Empty;
            url = (new Uri(url)).LocalPath;
            if (url.Length == 0) url += "/";
            var find = $"/{route}".ToLower();
            return (endCheckUrl ? url.EndsWith(find) : url.StartsWith(find)) ? @class : string.Empty;
        }
        public static string ActivePage(this IHtmlHelper html, string controller, string action = null, string @class = "active")
        {
            var currentController = html.ViewContext.RouteData.Values["controller"] as string;
            var currentAction = html.ViewContext.RouteData.Values["action"] as string;
            if (action == null) return StrEquals(currentController, controller) ? @class : string.Empty;
            var accepted = StrEquals(currentController, controller) && StrEquals(currentAction, action);
            return accepted ? @class : string.Empty;
        }
        public static bool IsAjaxRequestOrNull(this HttpContext context)
        {
            var header = context?.Request.Headers;
            if (header == null) return true;
            var result = header["X-Requested-With"] + "";
            return StrEquals(result, "XmlHttpRequest");
        }
        public static bool IsRefreshingOrNull(this HttpContext context)
        {
            var header = context?.Request.Headers;
            if (header == null) return true;
            var result = (header["Cache-Control"] + "");
            return StrEquals(result, "max-age=0");
        }
        private static bool StrEquals(string str1, string st2)
        {
            return string.Equals(str1, st2, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}