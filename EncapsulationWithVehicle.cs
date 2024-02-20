// Os campos modelo e ano são encapsulados como private, o que significa que eles não podem ser acessados diretamente de fora da classe Carro.
// Propriedades públicas (Modelo e Ano) são definidas para fornecer acesso controlado aos campos encapsulados. Isso permite que o código externo leia e modifique esses campos, mas somente através das propriedades, onde validações e lógica adicional podem ser aplicadas, como a verificação do ano válido no setter da propriedade Ano.
// Tentar acessar diretamente os campos privados modelo e ano fora da classe resultaria em um erro de compilação.
// O acesso aos campos é feito apenas por meio das propriedades, garantindo que a validação e a lógica de controle de acesso sejam aplicadas.

using System;

class Carro
{
    // Campos privados encapsulados
    private string modelo;
    private int ano;

    // Propriedades públicas para acessar os campos encapsulados
    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public int Ano
    {
        get { return ano; }
        set 
        { 
            if (value > 0)
                ano = value;
            else
                Console.WriteLine("Ano inválido.");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Carro meuCarro = new Carro();

        // Atribuição de valor à propriedade Modelo (acesso controlado)
        meuCarro.Modelo = "Toyota Corolla";

        // Tentativa de atribuição de valor diretamente ao campo privado (gerará um erro de compilação)
        // meuCarro.modelo = "Toyota Corolla"; // Isso não é possível devido à proteção por encapsulamento

        // Atribuição de valor à propriedade Ano (acesso controlado com validação)
        meuCarro.Ano = 2022;

        // Tentativa de atribuição de valor inválido à propriedade Ano (será tratado)
        meuCarro.Ano = -1; // Isso mostrará "Ano inválido."

        // Exibição dos valores através das propriedades (acesso controlado)
        Console.WriteLine($"Modelo: {meuCarro.Modelo}, Ano: {meuCarro.Ano}");
    }
}