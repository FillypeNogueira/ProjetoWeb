using Microsoft.AspNetCore.Mvc;
using Projeto_Sistema_WEB.Model;

namespace Projeto_Sistema_WEB.Controllers
{
    [Route("api/Telefone")]
    public class TelefoneController
    {
        private List<Telefone> telefones = new List<Telefone>();

        [HttpGet]
        public List<Telefone> GetTelefones()
        {
            return telefones;
        }

        [HttpGet]
        public Telefone GetTelefoneById(int id)
        {
            return telefones.Find(x => x.Id == id);
        }

        [HttpPost]
        public void AdicionarTelefone([FromBody] Telefone telefone)
        {
            telefones.Add(telefone);
        }

        [HttpPut] 
        public void AlterarTelefone(int id, [FromBody] Telefone telefone)
        {
            var telefoneExistente = telefones.FindIndex(x => x.Id == id);

            if(telefoneExistente != -1)
            {
                telefones[telefoneExistente] = telefone;
            }

        }

        [HttpDelete]
        public void DeletarTelefone(int id)
        {
            var telefoneExistente = telefones.Find(x => x.Id == id);

            if(telefoneExistente != null)
            {
                telefones.Remove(telefoneExistente);
            }
        }
       
        
    }
}