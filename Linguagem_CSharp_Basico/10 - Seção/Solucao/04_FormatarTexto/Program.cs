using System;

namespace _04_FormatarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Felipe Cruz";
            string texto = "Bem vindo" + nome + "! Feliz Natal!";

            string textoFormatado = string.Format("Bem vindo {0}! Feliz natal !{0} {1}", nome, "Feliz");

            Console.WriteLine(texto);
            Console.WriteLine(textoFormatado);

            Console.ReadKey();
        }
    }
}
