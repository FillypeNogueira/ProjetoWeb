using Microsoft.AspNetCore.Mvc;
using Projeto_Sistema_WEB.Model;

namespace Projeto_Sistema_WEB.Controllers
{
    [Route("api/Carrinho")]

    public class CarrinhoController : Controller
    {

        private static List<Carrinho> carrinhos = new List<Carrinho>();

        [HttpGet]
        public List<Carrinho> GetCarrinhos()
        {
            return carrinhos;
        }

        [HttpPost]
        public  void AdicionarCarrinho([FromBody]Carrinho carrinho)
        {
            carrinhos.Add(carrinho);
        }

        [HttpPut("{id}")]
        public void AtualizarCarrinho(int id, [FromBody]Carrinho carrinhoAtualizado)
        {
            var carrinhoExistente = carrinhos.FirstOrDefault(x => x.Id == id);

            if(carrinhoExistente != null)
            {
                carrinhoExistente.Produtos = carrinhoAtualizado.Produtos;
            }
        }

        [HttpDelete("{id}")]
        public void ExcluirCarrinho(int id)
        {
            var carrinhoExistente = carrinhos.FirstOrDefault(x => x.Id == id);
        }

       /*[HttpGet]
        public  List<Carrinho> GetCarrinho(int id)
        {
            return  carrinhos.FirstOrDefault(x => x.Id == id);
        }*/
        
    }
}