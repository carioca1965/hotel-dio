namespace HotelDesafio.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            Hospedes = new List<Pessoa>();
            DiasReservados = diasReservados;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count > Suite.Capacidade)
                throw new Exception("A quantidade de hóspedes excede a capacidade da suíte.");

            Hospedes = hospedes;
        }

        public int ObterQuantidadeHospedes() => Hospedes.Count;

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            if (DiasReservados > 10)
                valor *= 0.90m;
            return valor;
        }
    }
}
