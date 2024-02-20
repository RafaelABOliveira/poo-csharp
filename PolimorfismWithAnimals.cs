// A classe Animal é a classe base com um método FazerBarulho() que é marcado como virtual, indicando que pode ser substituído por métodos nas classes derivadas.
// As classes Cachorro e Gato estendem a classe Animal e substituem o método FazerBarulho() para fornecer o comportamento específico para cada tipo de animal.
// A função FazerBarulhoDoAnimal() aceita um parâmetro do tipo Animal e chama o método FazerBarulho(). Quando chamada com instâncias de diferentes tipos de animais, o método FazerBarulho() apropriado para cada tipo de animal é invocado, graças ao polimorfismo.

using System;

// Classe base
class Animal
{
    public string Name { get; set; }

    // Método fazerBarulho() é definido na classe base
    // A palavra chave 'virtual' é importante para habilitarmos o comportamento de polimorfismo
    public virtual void FazerBarulho()
    {
        Console.WriteLine("O animal faz algum barulho");
    }
}

// Classes derivadas (subclasses) que estendem Animal
class Cachorro : Animal
{
    // Substituindo o método FazerBarulho() na classe derivada Cachorro
    public override void FazerBarulho()
    {
        Console.WriteLine("O cachorro late");
    }
}

class Gato : Animal
{
    // Substituindo o método FazerBarulho() na classe derivada Gato
    public override void FazerBarulho()
    {
        Console.WriteLine("O gato mia");
    }
}

class Program
{
    static void FazerBarulhoDoAnimal(Animal animal)
    {
        animal.FazerBarulho();
    }

    static void Main(string[] args)
    {
        // Criando instâncias das classes derivadas
        Cachorro cachorro = new Cachorro { Name = "Rex" };
        Gato gato = new Gato { Name = "Garfield" };

        // Chamando a função com instâncias de diferentes tipos de animais
        FazerBarulhoDoAnimal(cachorro); // Saída: O cachorro late
        FazerBarulhoDoAnimal(gato);     // Saída: O gato mia
    }
}