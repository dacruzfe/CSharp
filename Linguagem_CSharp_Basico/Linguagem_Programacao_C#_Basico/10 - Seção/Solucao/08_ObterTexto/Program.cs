using System;

namespace _08_ObterTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            String texto = "Olá a todos! Desejo feliz ano novo!";

            // Com substring você consegue extrair qualquer informação dentro de um texto
            String frase = texto.Substring(13);
            String palavra = texto.Substring(13, 6);

            Console.WriteLine("2 frase: " + frase);
            Console.WriteLine("Palavra: " + palavra);

            Console.ReadKey();
        }
    }
}
