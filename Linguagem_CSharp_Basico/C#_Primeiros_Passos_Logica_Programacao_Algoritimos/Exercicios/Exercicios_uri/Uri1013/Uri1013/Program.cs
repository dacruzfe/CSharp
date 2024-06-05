using System;
using System.Globalization;

namespace Uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, maiorAB, ehMaior;
            string[] valores = Console.ReadLine().Split(' ');
            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            C = int.Parse(valores[2]);

            maiorAB = (A + B + Math.Abs(A - B)) / 2;

            ehMaior = (maiorAB + C + Math.Abs(maiorAB - C)) / 2;

            Console.WriteLine(ehMaior + " eh o maior");
        }
    }
}
