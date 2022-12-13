using System;
using System.Security.Claims;
using System.Security.Principal;

namespace NewsCmsProject.Extensions
{
    public static class ClaimExt
    {
        public static int? GetId(this IIdentity user)
        {
            try
            {
                var claims = user as ClaimsIdentity;
                return int.Parse(claims.FindFirst(ClaimTypes.NameIdentifier).Value);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static string GetEmail(this IIdentity user)
        {
            try
            {
                var claims = user as ClaimsIdentity;
                return claims.FindFirst(ClaimTypes.Email).Value;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}