using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Motel.Application.Auth;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AppTestController : ControllerBase
    {
        private readonly ICryptorFactory _cryptor;

        // GET: api/<AppTestController>
        public AppTestController(ICryptorFactory cryptor)
        {
            _cryptor = cryptor;
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
    }
}
