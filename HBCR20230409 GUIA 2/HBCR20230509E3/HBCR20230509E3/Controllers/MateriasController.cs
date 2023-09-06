using HBCR20230509E3.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HBCR20230509E3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriasController : ControllerBase
    {
        static List<Materias> maters = new List<Materias>();

        [HttpGet]
        public IEnumerable<Materias> Get()
        {
            return maters;
        }

        // POST api/<ClientsController>
        [HttpPost]
        public IActionResult Post([FromBody] Materias materia)
        {
            maters.Add(materia);
            return Ok();
        }

        // DELETE api/<ClientsController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingClient = maters.FirstOrDefault(c => c.Id == id);
            if (existingClient != null)
            {
                maters.Remove(existingClient);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

    }
}
