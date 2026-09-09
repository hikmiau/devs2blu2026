using Microsoft.AspNetCore.Mvc;
using MinhaPrimeiraApi.Models;

namespace MinhaPrimeiraApi.Controllers;

public class ClienteController : ControllerBase
{
        private static List<Cliente> clientes = [new(){Id = 1, Nome = "Cliente 1", Email = "cliente1@email.com"},
                                                 new(){Id = 2, Nome = "Cliente 2", Email = "cliente2@email.com"},
                                                 new(){Id = 3, Nome = "Cliente 3", Email = "cliente3@email.com"}];

        public static int idCounter;

        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> Get()
        {
            return clientes;
        }
        
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(int id)        
        {
            Console.WriteLine("ID: " + id);
            Cliente cliente = clientes.FirstOrDefault(c => c.Id == id);
            return cliente is null ? NotFound() : Ok(cliente);
        }

        [HttpPost]
        public ActionResult<Cliente> Post([FromBody] Cliente cliente)
        {
            idCounter++;
            cliente.Id = idCounter;
            clientes.Add(cliente);
            return cliente;
        }

        [HttpPut("{id:int}")]
        public ActionResult<Cliente> Put(int id, [FromBody] Cliente cliente)
        {
            Cliente clienteExistente = clientes.FirstOrDefault(c => c.Id == id);
            if (clienteExistente is null) return NotFound();
            clienteExistente.Nome = cliente.Nome;
            clienteExistente.Email = cliente.Email;
            return Ok(clienteExistente);
        }
}
