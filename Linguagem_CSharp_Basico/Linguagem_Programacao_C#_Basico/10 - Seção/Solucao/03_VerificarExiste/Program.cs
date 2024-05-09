using System;

namespace _03_VerificarExiste
{
    class Program
    {
        static void Main(string[] args)
        {
            // Existem tres formas de identificar se o texto existe na frase
            // A primeira é saber se ele existe no inicio da frase
            // A segunda é verificar se o texto está no final da frase 
            // E a terceira é verificar se o texto existe na frase

            string texto = "Olá amigos do Paulo Roberto Golveia!";
            Console.WriteLine("Verificar existencia no inicio: " + texto.StartsWith("Olá"));
            Console.WriteLine("Verificar existencia no final: " + texto.EndsWith("!"));
            Console.WriteLine("Verificar existencia: " + texto.Contains("Roberto"));

            Console.ReadKey();
        }
    }
}
