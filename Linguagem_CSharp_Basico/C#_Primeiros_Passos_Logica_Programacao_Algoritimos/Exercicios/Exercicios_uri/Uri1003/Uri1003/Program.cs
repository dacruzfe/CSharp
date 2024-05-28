using System;
using System.Globalization;

namespace Uri1003
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, SOMA;

            A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
        }
    }
}
