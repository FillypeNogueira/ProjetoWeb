using Microsoft.AspNetCore.Mvc;
using Projeto_Sistema_WEB.Model;

namespace Projeto_Sistema_WEB.Controllers
{
    [Route("api/Clinte")]
    public class ClienteController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        [HttpGet]
        public List<Cliente> GetClientes()
        {
            return clientes;
        }

        [HttpPost]
        public void AddClientes([FromBody] Cliente cliente)
        {
           clientes.Add(cliente); 
        }

        [HttpPut]
        public void AlterClientes(int id, [FromBody] Cliente cliente)
        {
            var index = clientes.FindIndex(x => x.Id == id);

            if(index != -1)
            {
                clientes[index] = cliente;
            }
        }

        [HttpDelete]
        public void RemoveClientes(int id)
        {
            var clienteRemover = clientes.Find(x => x.Id == id);

            if(clienteRemover != null)
            {
                clientes.Remove(clienteRemover);
            }
        }
        
    }
}