namespace Projeto_Sistema_WEB.Model
{
    public class Pedido
    {
        public int Id {get; set;}
        public int Quantidade {get; set;}

        public double Preco {get; set;}

        public string Status {get; set;} 

        public Cliente Cliente {get; set;}

        public Produto Produto {get; set;}
        
        public Pedido(int id, int quantidade, double preco, string status, Cliente cliente, Produto produto)
        {
            Id = id;
            Quantidade = quantidade;
            Preco = preco;
            Status = status;
            Cliente = cliente;
            Produto = produto;
        }
    }
}