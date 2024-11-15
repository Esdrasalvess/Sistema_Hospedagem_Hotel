namespace Sistema_de_Hospedagem_de_um_Hotel.Models
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
            // Verifica se a capacidade da suíte é suficiente para a quantidade de hóspedes
            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                // Lança uma exceção caso a capacidade seja insuficiente
                throw new Exception("A capacidade da suíte é insuficiente para a quantidade de hóspedes.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // Retorna a quantidade de hóspedes
            return Hospedes?.Count ?? 0;
        }

        public decimal CalcularValorDiaria()
        {
            // Calcula o valor da diária sem desconto
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Aplica desconto de 10% se a reserva for igual ou superior a 10 dias
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.1m;
            }

            return valor;
        }
    }
}