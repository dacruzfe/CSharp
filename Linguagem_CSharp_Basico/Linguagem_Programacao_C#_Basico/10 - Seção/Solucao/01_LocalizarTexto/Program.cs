using System;

namespace _01_LocalizarTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "Olá amigos, estou muito feliz de estar aqui com vocês.Desejo a todos um feliz ano novo!";
            string palavra = "feliz";

            Console.WriteLine("tamanho do texto: " + texto.Length);
            Console.WriteLine("Localizar palavra: " + texto.IndexOf(palavra));// ele retorna um inteiro com a posição a onde está a palavra procurada
            Console.WriteLine("Localiza Último: " + texto.LastIndexOf(palavra));// lastIndexOf localiza a ultima ocorrencia da palavra que eu informar


            Console.ReadKey();
        }
    }
}
