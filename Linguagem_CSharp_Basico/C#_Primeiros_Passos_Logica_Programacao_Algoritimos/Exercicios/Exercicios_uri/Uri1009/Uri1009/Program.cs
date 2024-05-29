using System;
using System.Globalization;

namespace Uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor = Console.ReadLine();

            double salario, vendas, totalReceber;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalReceber = salario + vendas * 0.15;

            Console.WriteLine("TOTAL = R$ " + totalReceber.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
