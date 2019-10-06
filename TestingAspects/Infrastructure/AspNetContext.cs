using Backend.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingAspects.Infrastructure
{
    public class AspNetContext : BosContext
    {

        private readonly IHttpContextAccessor _httpContextAccessor;

        public AspNetContext(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetAuthenticatedUserPrinepal()
        {
            return _httpContextAccessor.HttpContext.User.Identity.Name;
        }

        public string GetClientApplication()
        {
            return _httpContextAccessor.HttpContext.Request.Headers["bos-app-id"];
        }

        public string GetCorrelationId()
        {
            return _httpContextAccessor.HttpContext.Request.Headers["bos-correlation-id"];
        }

        public string GetRequestId()
        {
            return _httpContextAccessor.HttpContext.TraceIdentifier;
        }
    }
}
