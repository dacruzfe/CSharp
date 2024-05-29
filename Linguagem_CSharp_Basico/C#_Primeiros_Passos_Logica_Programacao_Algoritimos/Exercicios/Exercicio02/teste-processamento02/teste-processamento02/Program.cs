using System;
using System.Globalization;

namespace teste_processamento02
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Fazer um programa para ler as medidas da base e altura de um retângulo. Em seguida, mostrar o valor da área, 
             * perímetro e diagonal deste retângulo, com quatro casas decimais, conforme exemplo.
             * _______________________________________________
             * Entrada:             |    Saída:
             * -----------------------------------------------
             * 5.0                  | AREA = 20.0000
             * 4.0                  | PERIMETRO = 18.0000
             *                      | DIAGONAL = 6.4031
             *________________________________________________ 
             *************************************************/

            double b, a, area, perimetro, diagonal;

            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calculo da área = base x altura
            area = b * a;

            // Calculo de perimetro é 2 vezes a base + 2 vezes altura
            perimetro = 2 * (b + a);

            // Diagonal é o teorema de pitagoras raiz quadrada, base ao quadrado vezes altura ao quadrado
            // O math.Pow representa a base elevado a segunda potencia, elevado ao quadrado
            diagonal = Math.Sqrt(Math.Pow(b, 2.0) + Math.Pow(a, 2.0));

            Console.WriteLine("AREA = " + area.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + diagonal.ToString("F4", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
