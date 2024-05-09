using System;

namespace _07_DividirTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomes = "joão, Maria, José, Jesus, Felipe, Tiago e Paulo";
            string[] separador = { ", ", " e " };
            string[] nomeArray = nomes.Split(separador, StringSplitOptions.None);

            foreach (string nome in nomeArray)
            {
                Console.WriteLine(nome);
            }
            
            Console.ReadKey();
        }
    }
}
