namespace Projeto_Sistema_WEB.Model
{
    public class Telefone
    {
        public int Id {get; set; }
        public string DDD {get; set;}
        public string Numero {get; set; }
        public int ClienteId {get; set;}

        public Telefone(int id, string ddd, string numero, int clienteId)
        {
            Id = id;
            DDD = ddd;
            Numero = numero;
            ClienteId = clienteId;
        }
    }
}