using System;
using System.Globalization;

namespace Uri1004
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, PROD;

            n1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            PROD = n1 * n2;


            Console.WriteLine("PROD = " + PROD);
        }
    }
}
