using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIDemoGit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class testController1 : ControllerBase
    {
        // GET: api/<testController1>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<testController1>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<testController1>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<testController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<testController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
