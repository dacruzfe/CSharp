using System;

namespace _05_VariavelCharString
{
    class Program
    {
        static void Main(string[] args)
        {
            char meuChar = '!';
            string meuString = "O char armazena apenas 16 bytes apenas 1 caracter, já string pode ter varios";

            Console.Write(meuString + meuChar);
            Console.WriteLine("\n"+"Variaveis de Texto char e String");
            Console.ReadKey();
            
        }
    }
}
