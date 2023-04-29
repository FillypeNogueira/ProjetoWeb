using Microsoft.AspNetCore.Mvc;
using Projeto_Sistema_WEB.Model;

namespace Projeto_Sistema_WEB.Controllers
{
    [Route("api/controller")]
    public class EnderecoController
    {
        private List<Endereco> Enderecos = new List<Endereco>();

        [HttpGet]
        public List<Endereco> GetEnderecos()
        {
            return Enderecos;
        }

        [HttpGet("{id}")]
        public Endereco GetEnderecosById(int id)
        {
            return Enderecos.Find(x => x.Id == id);
        }

        public void AdicionarEnderecos(int id, [FromBody] Endereco endereco)
        {
            Enderecos.Add(endereco);
        }

        public void AlterarEnderecos(int id, [FromBody] Endereco endereco)
        {
            var enderecoExistente = Enderecos.Find(x => x.Id == id);

            if(enderecoExistente != null)
            {
                enderecoExistente.Rua = endereco.Rua;
                enderecoExistente.Cidade = endereco.Cidade;
                enderecoExistente.Estado = endereco.Estado;
            }
        }

        [HttpDelete]
        public void DeletarEndereco(int id)
        {
            var enderecoExistente = Enderecos.Find(x => x.Id == id);

            if(enderecoExistente != null)
            {
                Enderecos.Remove(enderecoExistente);
            }
        }
        
    }
}