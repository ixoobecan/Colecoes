using System;
using System.Collections.Generic;

namespace CDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dicionario GEN!");

            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("Mentalidade de Crescimento", new string(" é quando acreditamos que nossas qualidades podem sempre ser cultivadas, o que nos leva a usar críticas, dificuldades e desafios como o ponto de partida para o desenvolvimento."));
            dic.Add("Persistência", new string(" é a capacidade de agir com constância para alcançar um objetivo."));
            dic.Add("Responsabilidade Pessoal", new string("consiste, portanto, em saber como se comprometer a criar mudanças que sejam benéficas."));
            dic.Add("Trabalho em Equipe", new string(""));
            dic.Add("Proatividade", new string(""));
            dic.Add("Orientação ao Detalhe", new string(""));
            dic.Add("Comunicação", new string(""));


            foreach (KeyValuePair<string, string> kvp in dic)
            {
                Console.WriteLine($" BMH = {kvp.Key} | Significado = {kvp.Value}");
            }

            Console.WriteLine($"{dic["Comunicação"]}"); 
        }
    }
}