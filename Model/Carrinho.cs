namespace Projeto_Sistema_WEB.Model
{
    public class Carrinho
    {
        public List <Produto> Produtos {get; set;}

        public Carrinho()
        {
            Produtos = new List<Produto>();
        }

        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
        }

        public void RemoverProduto(Produto produto)
        {
            Produtos.Remove(produto);
        }
    }
}