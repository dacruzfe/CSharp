using System;

namespace _06_RemoverEspaco
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "                      Olá Amigos do Elias!                                    ";
            Console.WriteLine("Inicio: " + texto.TrimStart());//Para remover espaços no começo do texto 
            Console.WriteLine("Inicio: " + texto.TrimStart().Length);

            Console.WriteLine("Final: " + texto.TrimEnd()); //Para remover espaços no final do texto
            Console.WriteLine("Final: " + texto.TrimEnd().Length);

            Console.WriteLine("Tudo: " + texto.Trim());//Para remover espaços tanto no começo quanto no final
            Console.WriteLine("Tudo: " + texto.Trim().Length);

            Console.ReadKey();
        }
    }
}
