using Microsoft.AspNetCore.Mvc;

using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AutenticationCookieControladores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        static List<object> data = new List<object>();

        // GET: api/<TestController>
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<object> Get()
        {
            return data;
        }


        // POST api/<TestController>
        [AllowAnonymous]
        [HttpPost]
        public IActionResult Post(string name, string lastname)
        {
            data.Add(new {name, lastname});
            return Ok();
        }



        // DELETE api/<TestController>/5
        [HttpDelete]
        [Authorize]
        public IActionResult Delete()
        {
            data = new List<object>();
            return Ok();
        }
    }
}
