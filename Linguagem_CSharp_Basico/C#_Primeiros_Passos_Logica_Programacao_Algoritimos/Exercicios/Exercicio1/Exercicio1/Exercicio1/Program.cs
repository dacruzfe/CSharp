using System;
using System.Globalization;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Minha resposta:
            Console.WriteLine("Por favor digite a largura do terreno: ");
            double largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor digite o comprimento do terreno: ");
            double comprimento = double.Parse(Console.ReadLine());
            Console.WriteLine("Por favor digite o Valor do Metro Quadrado: ");
            double valorPorMetro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); ;
            double area = largura * comprimento;
            double preco = area * valorPorMetro;


            Console.WriteLine("O total de Área é: " + area.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O Preço total é: " + preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("===============================================================");

            // Resposta do professor
            double larguraTerreno, comprimentoTerreno, precoMetroQuadrado, areaTerreno, precoTerreno;

            larguraTerreno = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            comprimentoTerreno = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaTerreno = larguraTerreno * comprimentoTerreno;
            precoTerreno = areaTerreno * precoMetroQuadrado;

            Console.WriteLine("AREA = " + areaTerreno.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PRECO = " + precoTerreno.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();


        }
    }
}
