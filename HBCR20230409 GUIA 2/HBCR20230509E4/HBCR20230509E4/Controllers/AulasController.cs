using HBCR20230509E4.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HBCR20230509E4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AulasController : ControllerBase
    {
        static List<Aulas> aulas = new List<Aulas>
    {
        new Aulas { Id = 1, Grado = "Primero", Maestro = "Profesor1" },
        new Aulas { Id = 2, Grado = "Segundo", Maestro = "Profesor2" },
        new Aulas { Id = 3, Grado = "Tercero", Maestro = "Profesor3" }
    };
        [HttpGet]
        public IEnumerable<Aulas> Get()
        {
            return aulas;
        }

        

    }
}
