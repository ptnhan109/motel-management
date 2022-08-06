using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Motel.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppTestController : ControllerBase
    {
        // GET: api/<AppTestController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
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
