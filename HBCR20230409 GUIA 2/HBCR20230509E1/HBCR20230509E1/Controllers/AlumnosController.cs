using HBCR20230509E1.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HBCR20230509E1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlumnosController : ControllerBase
    {
        static List<Alumnos> alumns = new List<Alumnos>();

        [HttpGet]
        public IEnumerable<Alumnos> Get()
        {
            return alumns;
        }

        [HttpGet("{id}")]
        public Alumnos Get(int id)
        {
            var alumno = alumns.FirstOrDefault(c => c.Id == id);
            return alumno;
        }


        [HttpPost]
        public IActionResult Post([FromBody] Alumnos alumno)
        {
            alumns.Add(alumno);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Alumnos alumno)
        {
            var existingClient = alumns.FirstOrDefault(c => c.Id == id);
            if (existingClient != null)
            {
                existingClient.Name = alumno.Name;
                existingClient.lastName = alumno.lastName;
                return Ok();
            }
            else
            {
                return NotFound();
            }

        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingClient = alumns.FirstOrDefault(c => c.Id == id);
            if (existingClient != null)
            {
                alumns.Remove(existingClient);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
