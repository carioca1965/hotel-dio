using HotelDesafio.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("=== Sistema de Hospedagem - DIO ===");

var hospedes = new List<Pessoa>()
{
    new Pessoa("Carlos", "Silva"),
    new Pessoa("Ana", "Souza")
};

var suite = new Suite("Premium", 3, 150.00m);

var reserva = new Reserva(12);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

Console.WriteLine($"
Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total da reserva: {reserva.CalcularValorDiaria():C}");
