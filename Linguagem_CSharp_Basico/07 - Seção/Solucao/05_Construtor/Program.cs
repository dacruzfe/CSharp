using System;

namespace _05_Construtor
{
    class Program
    {
        ///<Sumary>
        ///Construtor, Construtor é a forma de se instaciar um objeto
        ///</Sumary>


        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Carro carro2 = new Carro("FIAT", "Uno", 2010);

            string carrosExibe = "Carro Marca: " + carro.Marca + " - "+ "Modelo:  " + carro.Modelo + " - " + "Ano: " + carro.Ano;
            string carroExibe2 = carro2.Marca + " - " + carro2.Modelo + " - " + carro2.Ano;

            Console.WriteLine("Exibição do carro 1: " + carrosExibe);
            Console.WriteLine("Exibição do Carro 2: " + carroExibe2);
        }
    }
}
