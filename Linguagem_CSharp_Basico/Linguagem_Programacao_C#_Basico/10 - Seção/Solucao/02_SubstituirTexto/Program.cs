using System;

namespace _02_SubstituirTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Substituindo textos na string
            string texto = "Olá amigos do João!";
            Console.WriteLine(texto);
            string textoSub = texto.Replace("João", "José");
            Console.WriteLine(textoSub);
            Console.WriteLine(texto.Replace("João", "Paulo"));
            Console.ReadKey();
        }
    }
}
