using Microsoft.AspNetCore.Mvc;
using Projeto_Sistema_WEB.Model;

namespace Projeto_Sistema_WEB.Controllers
{
    [Route("api/Carrinho")]

    public class CarrinhoController : Controller
    {

        private static List<Carrinho> Carrinhos = new List<Carrinho>();

        [HttpGet]
        public List<Carrinho> GetCarrinhos()
        {
            return Carrinhos;
        }

        [HttpPost]
        public  void AdicionarCarrinho([FromBody]Carrinho carrinho)
        {
            Carrinhos.Add(carrinho);
        }

        [HttpPut("{id}")]
        public void AtualizarCarrinho(int id, [FromBody]Carrinho carrinhoAtualizado)
        {
            var carrinhoExistente = Carrinhos.FirstOrDefault(c => c.Id == id);

            if(carrinhoExistente != null)
            {
                carrinhoExistente.Produtos = carrinhoAtualizado.Produtos;
            }
        }

        [HttpDelete("{id}")]
        public void ExcluirCarrinho(int id)
        {
            var carrinhoExistente = Carrinhos.FirstOrDefault(c => c.Id == id);
        }

        /*[HttpGet]
        public  List<Carrinho> GetCarrinho(int id)
        {
            return  Carrinhos.ToString().FirstOrDefault(c => c.Id == id);
        }*/
        
    }
}