namespace Projeto_Sistema_WEB.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int QtdEstoque { get; set; }
        public int ClienteId { get; set; }
        public double Preco { get; set; }

        public Produto(int id, string nome, string descricao, int qtdEstoque, int clienteId, double preco)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            QtdEstoque = qtdEstoque;
            ClienteId = clienteId;
            Preco = preco;
        }
    }
}