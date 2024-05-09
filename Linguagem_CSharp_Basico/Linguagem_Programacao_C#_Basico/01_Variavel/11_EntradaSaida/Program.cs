using System;

namespace _11_EntradaSaida
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Nome");
            Console.WriteLine("Nome");
            Console.Write("Nome");
            Console.WriteLine("Nome");
            Console.Write("Nome");
            Console.WriteLine("Nome");
            */

            /*
            int CodigoASCII = Console.Read();
            char Letra = (char)CodigoASCII;
            Console.WriteLine("Código ASCII: " + CodigoASCII + " - Letra : " + Letra);
            */

            /*ConsoleKeyInfo Letra = Console.ReadKey();
            Console.WriteLine("Tecla digitada Executa: " + Letra.KeyChar);
            */

            string Frase = Console.ReadLine();
            Console.WriteLine(Frase);

            Console.WriteLine("Entrada e Saida de dados no console!");
            Console.ReadKey();
            
        }
    }
}
