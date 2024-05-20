using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Helpers;
using Motel.Common.Enums;
using Motel.Common.Generics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        [HttpPost("{type}")]
        public async Task<Response> Upload(EnumFileType type)
        {
            var file = Request.Form.Files.FirstOrDefault();
            if(file is null)
            {
                return Motel.Common.Generics.Response.Fail(HttpStatusCode.BadRequest, "1", "File not found");
            }

            var path = await FileHelper.SaveFile(file, type);

            return Common.Generics.Response.Succeed(HttpStatusCode.OK, path, "0", "Successed");
        }
    }
}
