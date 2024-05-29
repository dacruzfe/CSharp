using System;
using System.Globalization;

namespace uri1011
{
    class Program
    {
        static void Main(string[] args)
        {

            double raio, volume;

            //Recebo o valor do Raio
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Aqui uso os valores propostos no exercicio e faço o calculo para montar a esfera
            volume = 4.0 / 3.0 * 3.14159 * raio * raio * raio;

            Console.WriteLine("VOLUME = " + volume.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}