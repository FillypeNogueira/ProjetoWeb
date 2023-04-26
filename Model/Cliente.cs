namespace Projeto_Sistema_WEB.Model
{
    public class Cliente
    {
        public int Id {get; set; }
        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public string Email {get; set;}

        public Cliente (int id, string nome, string endereco, string telefone, string email)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Telefone = telefone;
            Email = email;
        }
    }
}