namespace Projeto_Sistema_WEB.Model
{
    public class Venda
    {
        public int Id {get; set; }
        public Produto? Produto { get; set; }
        public double Valor { get; set; }
        public Cliente? Cliente { get; set; }
        public DateTime Data { get; set; }
        
        public Venda(int id, Produto produto, double valor, Cliente cliente, DateTime data)
        {
            Id = id;
            Produto = produto;
            Valor = valor;
            Cliente = cliente;
            Data = data;
        }
    }
}