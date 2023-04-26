namespace Projeto_Sistema_WEB.Model
{
    public class Endereco
    {
        public int Id {get; set; }
        public string Rua {get; set;}

        public string Cidade {get; set;}

        public string Estado {get; set;}

        public Endereco(int id, string rua, string cidade, string estado)
        {
            Id = id;
            Rua = rua;
            Cidade = cidade;
            Estado = estado;
        }
    }
}