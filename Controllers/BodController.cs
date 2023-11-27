using Microsoft.AspNetCore.Mvc;
using Yc2023Veilingnew.Entiteiten;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yc2023Veilingnew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BodController : ControllerBase
    {
        [HttpGet("uitproberen")]
        public Bod Uitproberen()
        {
            Bod b = new Bod();
            b.Id = 4;
            b.Bieder = "Karel";
            return b;
        }
        // GET: api/<BodController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<BodController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BodController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<BodController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<BodController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
