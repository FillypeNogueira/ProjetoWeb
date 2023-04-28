namespace Projeto_Sistema_WEB.Model
{
    public class Departamento
    {
        public int Id { get; set; }

        public string Nome{ get; set; }

        public Departamento(string nome)
        {
            Nome = nome;
        }
    }
}