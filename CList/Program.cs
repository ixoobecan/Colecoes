using System;
using System.Collections.Generic;

namespace CList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Bichos");
            
           List<string> listName = new List<string>();
            // Posição 1 indice 0
            listName.Add("Gato");
            listName.Add("Cobra");
            listName.Add("Rato");
            listName.Add("Coruja");

            listName.Insert(1, "Cão");

            listName.Remove("Cobra");

            listName.RemoveAt(3); 
            //Tem que sair o Coruja (lembrar que Gato é a posição 0)

            foreach (string s in listName)
            {
                Console.WriteLine ($" Bicho: {s}");
            }

        
        }
    }
}
