using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIDemoGit.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController1 : ControllerBase
    {
        // GET: api/<BookController1>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BookController1>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BookController1>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BookController1>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BookController1>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
