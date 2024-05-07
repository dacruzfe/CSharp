using System;

namespace _02_Estatico
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            carro1.Cor = "Rosa";
            Carro.QuantidadeCarrosProduzidos = 2000000;

            Console.WriteLine("Hello World!");
        }
    }
}
