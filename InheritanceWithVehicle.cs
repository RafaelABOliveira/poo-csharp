// A classe Veiculo é a classe base que contém propriedades e métodos comuns a todos os veículos.
// A classe Carro estende a classe Veiculo, herdando suas propriedades e métodos. Além disso, adiciona sua própria propriedade Portas e método AbrirPorta().
// Dentro do método Main, criamos uma instância da classe Carro, configuramos suas propriedades e chamamos métodos tanto da classe base quanto da classe derivada.

using System;

// Classe base
class Veiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Ano { get; set; }

    public void Ligando()
    {
        Console.WriteLine("O veículo está ligado.");
    }

    public void Desligando()
    {
        Console.WriteLine("O veículo está desligado.");
    }
}

// Classe derivada (subclasse) que estende Veiculo
class Carro : Veiculo
{
    public int Portas { get; set; }

    public void AbrirPorta()
    {
        Console.WriteLine("Uma porta do carro foi aberta.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância da classe derivada Carro
        Carro carro = new Carro();
        carro.Marca = "Toyota";
        carro.Modelo = "Corolla";
        carro.Ano = 2022;
        carro.Portas = 4;

        // Acessando propriedades e métodos da classe base e da classe derivada
        Console.WriteLine($"Marca: {carro.Marca}, Modelo: {carro.Modelo}, Ano: {carro.Ano}, Portas: {carro.Portas}");
        carro.Ligando();    // Método da classe base
        carro.AbrirPorta(); // Método da classe derivada
    }
}