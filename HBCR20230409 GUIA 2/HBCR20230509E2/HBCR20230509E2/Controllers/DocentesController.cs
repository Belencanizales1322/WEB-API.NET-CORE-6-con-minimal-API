using HBCR20230509E2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HBCR20230509E2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocentesController : ControllerBase
    {

        static List<Docentes> docents = new List<Docentes>();


        // GET: api/<ClientsController>
        [HttpGet]
        public IEnumerable<Docentes> Get()
        {
            return docents;
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public Docentes Get(int id)
        {
            var docentes = docents.FirstOrDefault(c => c.Id == id);
            return docentes;
        }

        // POST api/<ClientsController>
        [HttpPost]
        public IActionResult Post([FromBody] Docentes docentes)
        {
            docents.Add(docentes);
            return Ok();
        }
    }
}
