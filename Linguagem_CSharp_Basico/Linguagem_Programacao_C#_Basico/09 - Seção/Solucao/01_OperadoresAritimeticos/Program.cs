using System;

namespace _01_OperadoresAritimeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nos c# se você tiver o sinal de mais com uma string ou texto ele fará uma concatenação,
            // mas se a condição estiver somada a outro numero ele fará a soma.
            // porém ele só irá somar se os dois numeros estiverem entre parenteses quando acrescentados de um texto.
            Console.WriteLine("A Soma de 2 + 2 é: " + (2 + 2));
            Console.WriteLine("Subtração: " + (5 - 2));
            Console.WriteLine("Multiplicação: " + (3 * 9));
            Console.WriteLine("Divisão: " + (6 / 2));

            Console.WriteLine("Modulo ou Resto: " + (8 % 3));

            Console.ReadKey();
        }
    }
}
