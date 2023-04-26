namespace Projeto_Sistema_WEB.Model
{
    public class Pagamento
    {
        public int Id {get; set; }
        public string Tipo {get; set;}

        public double Valor {get; set;}

        public DateTime Data {get; set;}

        public Pagamento(int id, string tipo, double valor, DateTime data)
        {
            Id = id;
            Tipo = tipo;
            Valor = valor;
            Data = data;
        }
    }
}