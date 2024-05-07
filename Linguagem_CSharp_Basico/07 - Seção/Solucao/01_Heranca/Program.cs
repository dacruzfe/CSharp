using System;
using _01_Heranca.Biblioteca;

namespace _01_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();

            Moto moto = new Moto();

            Veiculo vei = new Veiculo();


            carro.Marca = "HYNDAI";
            moto.Marca = "HONDA";
            vei.Marca = "Airbus";

        
            Console.WriteLine("Hello World!");
        }
    }
}
