namespace Projeto_Sistema_WEB.Model
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int QtdEstoque { get; set; }

        public Produto(int id, string nome, string descricao, int qtdEstoque)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            QtdEstoque = qtdEstoque;
        }
    }
}