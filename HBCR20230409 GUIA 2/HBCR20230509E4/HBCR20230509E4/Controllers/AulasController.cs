using HBCR20230509E4.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HBCR20230509E4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulasController : ControllerBase
    {
        static List<Aulas> aulas = new List<Aulas>();

        [HttpGet]
        public IEnumerable<Aulas> Get()
        {
            return aulas;
        }

        // POST api/<ClientsController>
        [HttpPost]
        public IActionResult Post([FromBody] Aulas aula)
        {
            aulas.Add(aula);
            return Ok();
        }

    }
}
