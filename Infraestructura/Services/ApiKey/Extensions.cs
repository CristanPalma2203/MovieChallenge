using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura.Services.ApiKey
{
    public static class Extensions
    {
        public static ClaimsIdentity GetClaimsIdentity(this IHttpContextAccessor httpContextAccessor)
        {
            return (ClaimsIdentity)httpContextAccessor.HttpContext.User.Identity;

        }
        public static bool isApiKeyAuthentication(this IHttpContextAccessor httpContextAccessor)
        {
            var identity = httpContextAccessor.GetClaimsIdentity();
            return identity.AuthenticationType == "API_KEY";

        }
        public static string GetEmailClientFromClaims(this IHttpContextAccessor httpContextAccessor)
        {
            var identity = httpContextAccessor.GetClaimsIdentity();
            var claim = identity.Claims.FirstOrDefault(x => x.Type == ClaimTypes.Email);
            return claim.Value;

        }
    }
}
