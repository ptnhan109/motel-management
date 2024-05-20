using System.Net;
using Motel.Common.Generics;

namespace Motel.Application.Services
{
    public abstract class Service
    {
        public virtual Response Accepted(object data = default) => Response.Succeed(HttpStatusCode.Accepted, data);

        public virtual Response BadRequest(string code = "", string message = "") => Response.Fail(HttpStatusCode.BadRequest, code, message);

        public virtual Response Created(object data = default) => Response.Succeed(HttpStatusCode.Created, data);

        public virtual Response Forbidden(string code = "", string message = "") => Response.Fail(HttpStatusCode.Forbidden, code, message);

        public virtual Response NotFound(string code = "", string message = "") => Response.Fail(HttpStatusCode.NotFound, code, message);

        public virtual Response Ok(object data = default, string code = "", string message = "") => Response.Succeed(HttpStatusCode.OK, data, code, message);

        public virtual Response Unauthorized(string code = "", string message = "") => Response.Fail(HttpStatusCode.Unauthorized, code, message);
    }
}
