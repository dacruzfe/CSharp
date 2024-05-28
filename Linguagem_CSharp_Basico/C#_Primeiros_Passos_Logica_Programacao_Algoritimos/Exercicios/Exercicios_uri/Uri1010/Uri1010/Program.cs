using System;
using System.Globalization;

namespace Uri1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod1, cod2, qte1, qt2;
            double preco1, preco2, totalPagar;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qt2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);


            totalPagar = preco1 * qte1 + preco2 * qt2;

            Console.WriteLine("VALOR A PAGAR: R$ " + totalPagar.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
