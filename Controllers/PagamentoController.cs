using Microsoft.AspNetCore.Mvc;
using Projeto_Sistema_WEB.Model;

namespace Projeto_Sistema_WEB.Controllers
{
    [Route("api/Pagamento")]
    public class PagamentoController
    {
        private readonly List<Pagamento> pagamentos = new List<Pagamento>();

        [HttpGet]
        public List<Pagamento> GetPagamentos()
        {
            return pagamentos;
        }
        
        [HttpGet]
        public Pagamento GetPagamentoById(int id)
        {
            return pagamentos.Find(x => x.Id == id);
        }

        [HttpPost]
        public void AdicionarPagamentos(int id, [FromBody] Pagamento pagamento)
        {
            pagamentos.Add(pagamento);
        }

        [HttpPut]
        public void AlterarPagamento(int id, [FromBody] Pagamento pagamento)
        {
            var PagamentoAlterar = pagamentos.FindIndex(x => x.Id == id);

            if(PagamentoAlterar != -1)
            {
                pagamentos[PagamentoAlterar] = pagamento;
            }
        }

        [HttpDelete]
        public void DeletarEndereco(int id)
        {
            var pagamentoExistente = pagamentos.Find(x => x.Id == id);

            if(pagamentoExistente != null)
            {
                pagamentos.Remove(pagamentoExistente);
            }
        }
        
    }
}