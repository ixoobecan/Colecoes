using System;
using System.Collections.Generic;

namespace CQueue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pessoas na fila: ");

            Queue<Pessoa> pessoas = new Queue<Pessoa>();

            pessoas.Enqueue(new Pessoa("Bruno, Oliveiros,29 "));
            pessoas.Enqueue(new Pessoa("Samira, Ixoobecan,31"));
            pessoas.Enqueue(new Pessoa("Nick, Toledo, 29"));
            pessoas.Enqueue(new Pessoa("Fernanda, Chagas, 25"));
            pessoas.Enqueue(new Pessoa("Monica, Souza, 45"));

            Console.WriteLine($"Primeiro da fila: {pessoas.Dequeue()}");

            pessoas.Peek();

            Console.WriteLine($"As pessoas da fila são: {pessoas.Count}");

            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.ToString());
            }

        }

        public class Pessoa
        {
        
            public string Nome { get; set; }
            public string Sobrenome { get; set; }
            public int Idade { get; set; }

             public Pessoa(string nome, string sobrenome, int idade)
            {
                Nome = nome;
                Sobrenome = sobrenome; 
                Idade = idade;
            }
            
            public override string ToString()
            {
                return $"Nome: {Nome} {Sobrenome} | Idade: {Idade}";
            }
        }
    }
}