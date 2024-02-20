//NNa agregação, um objeto de uma classe é composto por outros objetos, mas a existência desses objetos não é diretamente dependente do objeto principal
//Neste exemplo o professor existe independente do curso, gerando apenas a agregação

using System;
using System.Collections.Generic;

// Classe Professor
class Professor
{
    public string Nome { get; set; }

    public Professor(string nome)

        Nome = nome;
    }

    public void Ensinar()
    {
        Console.WriteLine($"{Nome} está ensinando.");
    }
}

// Classe Curso
class Curso
{
    public string Nome { get; set; }
    public List<Professor> Professores { get; set; }

    public Curso(string nome)
    {
        Nome = nome;
        Professores = new List<Professor>();
    }

    public void AdicionarProfessor(Professor professor)
    {
        Professores.Add(professor);
    }
}

// Classe Programa principal
class Program
{
    static void Main(string[] args)
    {
        // Criando professores
        Professor professor1 = new Professor("João");
        Professor professor2 = new Professor("Maria");

        // Criando curso e associando professores
        Curso curso = new Curso("Programação");
        curso.AdicionarProfessor(professor1);
        curso.AdicionarProfessor(professor2);

        // Chamando método de ensinar para cada professor no curso
        foreach (var professor in curso.Professores)
        {
            professor.Ensinar();
        }
    }
}