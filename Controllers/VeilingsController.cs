using Datalayer;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Yc2023Veilingnew.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeilingsController : ControllerBase
    {
        private MijnDatabases _mdc;

        public VeilingsController(MijnDatabases mdc)
        {
            _mdc = mdc;
        }
        // GET: api/<VeilingsController>
        [HttpGet("/ABC")]

        public Veilings VeilingsABC()
        {
            Veilings a = new Veilings();
            a.Datum = new DateTime();
            a.OpeningsBod = 2000;
            a.Duratie = 30;
            a.LaatsteBod = 4000;
            a.Minimumbod = 3000;
            _mdc.Add(a);
            _mdc.SaveChanges();
            return a;
        }
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<VeilingsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<VeilingsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<VeilingsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<VeilingsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
