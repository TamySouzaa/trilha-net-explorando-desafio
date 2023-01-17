namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                Console.WriteLine(" O Número de hospedes é maior que a capacidade ");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            
            int quantidadeHo = Hospedes.Count;
            return quantidadeHo;
        }

        public decimal CalcularValorDiaria()
        {
            
            decimal valor = DiasReservados * (Suite.ValorDiaria);

            
            if (DiasReservados >= 10)
            {
                valor = valor = (valor - valor/ 10);
            }

            return valor;
        }
    }
}