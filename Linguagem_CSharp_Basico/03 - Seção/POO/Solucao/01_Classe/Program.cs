using System;
using _01_Classe.Veiculo;

namespace _01_Classe
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro1 = new Carro();
            Carro carro2 = new Carro();

            Console.WriteLine("Marca: " + carro1.Marca);
            carro1.Marca = "BMW";
            Console.WriteLine("Marca: " + carro1.Marca);


            Console.WriteLine("Luzes Internas: " + carro1.LuzesInternas);
            carro1.AbrirPorta();
            Console.WriteLine("Luzes Internas: " + carro1.LuzesInternas);


            string statusFarol = carro1.AcenderFarolAutomaticamente();
            Console.WriteLine("Status do Farol: " + statusFarol);


            Console.ReadKey();

        }
    }
}
