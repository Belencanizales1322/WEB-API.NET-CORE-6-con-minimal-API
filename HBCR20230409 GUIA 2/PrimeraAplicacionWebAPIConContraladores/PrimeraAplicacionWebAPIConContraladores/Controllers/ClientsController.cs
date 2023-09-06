using Microsoft.AspNetCore.Mvc;
using PrimeraAplicacionWebAPIConContraladores.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PrimeraAplicacionWebAPIConContraladores.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        static List<Client> clients = new List<Client>();
        
        
        // GET: api/<ClientsController>
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return clients;
        }

        // GET api/<ClientsController>/5
        [HttpGet("{id}")]
        public Client Get(int id)
        {
            var client = clients.FirstOrDefault(c => c.Id == id);
            return client;
        }

        // POST api/<ClientsController>
        [HttpPost]
        public IActionResult Post([FromBody] Client client)
        {
            clients.Add(client);
            return Ok();
        }

        // PUT api/<ClientsController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Client client)
        {
            var existingClient = clients.FirstOrDefault(c => c.Id == id); 
            if (existingClient != null)
            {
                existingClient.Name = client.Name;
                existingClient.lastName = client.lastName;
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
            var existingClient = clients.FirstOrDefault(c => c.Id == id);
            if (existingClient != null)
            {
                clients.Remove(existingClient);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
