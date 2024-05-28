using System;
using System.Globalization;

namespace Uri1007
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, C, D, diferenca;

            A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            D = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            diferenca = (A * B) - (C * D);

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}
