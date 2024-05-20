using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Auth;
using Motel.Application.Services.MessageService;
using System.Collections.Generic;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AppTestController : ControllerBase
    {
        private readonly ICryptorFactory _cryptor;
        private readonly IMessageService _message;

        // GET: api/<AppTestController>
        public AppTestController(ICryptorFactory cryptor, IMessageService message)
        {
            _cryptor = cryptor;
            _message = message;
        }
        [HttpGet]
        public string Get()
        {
            return _cryptor.ToHashPassword("123456");
        }

        // GET api/<AppTestController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AppTestController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AppTestController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AppTestController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("e-mail")]
        public async Task<IActionResult> Send()
        {
            _message.Send("NhanPT", "Hello Nhan", "ptnhan109@gmail.com", "Hey you, It's auto message from iMomaSystem");
            return Ok();
        }
    }
}
