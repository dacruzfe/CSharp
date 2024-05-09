using System;

namespace _10_IntroducaoArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = {"Bernardo Cruz", "Ryan Santana", "Felipe Santana", "Kaua Silva", "Artur Silva"};

            Console.WriteLine("Nome de N3: " + nomes[2]);
            nomes[2] = "Felipe Cruz";
            Console.WriteLine("Nome de N3: " + nomes[2]);
            Console.WriteLine("Declarando Array!");
            Console.ReadKey();
        }
    }
}
