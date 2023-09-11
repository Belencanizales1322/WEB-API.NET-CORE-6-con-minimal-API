using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutenticationCookieControladores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    [Authorize]
    public class ProtetedController : ControllerBase
    {
        static List<object> data = new List<object>();

        // GET: api/<ProtetedController>
        [HttpGet]
        public IEnumerable<object> Get()
        {
            return data;
        }

        // POST api/<ProtetedController>
        [HttpPost]
        public IActionResult Post(string name, string lastName)
        {
            data.Add(new { name, lastName});
            return Ok();
        }
    }
}
