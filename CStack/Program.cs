using System;
using System.Collections.Generic;


namespace CStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Minha pilha de livro para ler: ");
           
            Stack<Livro> l = new Stack<Livro>();
             
            l.Push(new Livro ("It Ends with Us, 2015, Colleen Hoover"));
            l.Push(new Livro ("Ugly Love, 2012, Colleen Hoover"));
            l.Push(new Livro ("November 9, 2013, Colleen Hoover"));
            l.Push(new Livro ("Verity, 2018, Colleen Hoover"));

            l.Peek();
            l.Pop();
            l.Count();

            foreach (Livro livro in l) ;

        }
    }
    public class Livro
    {

        public string Titulo { get; set; }
        public int Ano { get; set; }
        public string Autor { get; set; }

        public Livro (string titulo, int ano, string autor)
        {
            Titulo = titulo;
            Ano = ano;
            Autor = autor;
        }

        public override string ToString()
        {
            return $"Livro: {Titulo}, {Ano} | Autor: {Autor}";
        }
    }
}


