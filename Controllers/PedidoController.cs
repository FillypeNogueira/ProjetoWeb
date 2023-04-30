using Microsoft.AspNetCore.Mvc;
using Projeto_Sistema_WEB.Model;


namespace Projeto_Sistema_WEB.Controllers
{
    [Route("api/Pedido")]
    public class PedidoController
    {
        private List<Pedido> pedidos = new List<Pedido>();

        [HttpGet]
        public List<Pedido> GetPedidos()
        {
            return pedidos;
        }

       /* [HttpGet]
        public List<Pedido> GetPedidosById(int id)
        {
            return pedidos.Find(x => x.Id == id);
        }
        */

        [HttpPost]
        public void AdicionarPedido([FromBody] Pedido pedido)
        {
            pedidos.Add(pedido);
        }

        [HttpPut]
        public void AlterarPedido(int id, [FromBody] Pedido pedido)
        {
            var pedidoExistente = pedidos.Find(x => x.Id == id);

            if(pedidoExistente != null)
            {
                pedidos[Convert.ToInt32(pedidoExistente)] = pedido;
            }
        }

        [HttpDelete]
        public void DeletarPedido(int id)
        {
            var pedidoExistente = pedidos.Find(x => x.Id == id);

            if(pedidoExistente != null)
            {
                pedidos.Remove(pedidoExistente);
            }
        }
    }
}