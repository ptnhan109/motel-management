using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;

namespace Motel.Application.Auth
{
    public interface IAppContextAccessor
    {
        Guid GetUserId();
    }
    internal class AppContextAccessor : IAppContextAccessor
    {
        private readonly IHttpContextAccessor _context;

        public AppContextAccessor(IHttpContextAccessor context)
        {
            _context = context;
        }
        public Guid GetUserId()
        {
            var claim = _context.HttpContext.User
                .Claims.FirstOrDefault(c => c.Type.Equals(ClaimTypes.NameIdentifier));
            if(claim == null)
            {
                return default;
            }

            return Guid.Parse(claim.Value);
        }
    }
}
