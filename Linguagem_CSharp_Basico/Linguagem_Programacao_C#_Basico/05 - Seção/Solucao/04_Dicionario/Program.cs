using System;
using System.Collections.Generic;

namespace _04_Dicionario
{
    class Program
    {
        static void Main(string[] args)
        {
            //No Dicionário quem cria o indice sou eu 
            Dictionary<string, int> dicionario = new Dictionary<string, int>();
            // Aqui o T1 é o Indice e o 128 é o valor que eu quero exibir
            dicionario.Add("T1", 128);
            dicionario.Add("T2", 256);

            Console.WriteLine(dicionario["T1"]);

            Console.ReadKey();
            
        }
    }
}
