using System;
using _02_Sobrescrita.Biblioteca;

namespace _02_Sobrescrita
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

            carro.Mover();
            moto.Mover();
            vei.Mover();


            Console.WriteLine("Hello World!");

            Console.ReadKey();
        }
    }
}
