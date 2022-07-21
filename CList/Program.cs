using System;
using System.Collections.Generic;

namespace CList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World List");
            
           List<string> listName = new List<string>();
            listName.Add ("Bruno");
            listName.Add("Mauricio");

            listName.Insert(1, "Jão");

            foreach (string s in listName)
            {
                Console.WriteLine ($" Pessoa: {s}");
            }

        
        }
    }
}
