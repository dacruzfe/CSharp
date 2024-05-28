using System;
using System.Globalization;

namespace Uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, consumoMedio;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consumoMedio = (double) x / y; // Aqui um exemplo de Casting, onde o double é incluido antes da divisão.

            Console.WriteLine(consumoMedio.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
