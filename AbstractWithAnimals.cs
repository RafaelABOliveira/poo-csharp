using System;

// Classe abstrata
abstract class Animal
{
    public abstract void EmitirSom(); // Método abstrato para ser implementado
}

// Classe derivada que implementa a classe abstrata
class Cachorro : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro late");
    }
}

class Gato : Animal
{
    public override void EmitirSom()
    {
        Console.WriteLine("O gato mia");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal cachorro = new Cachorro();
        cachorro.EmitirSom(); // Saída: O cachorro late
    }
}