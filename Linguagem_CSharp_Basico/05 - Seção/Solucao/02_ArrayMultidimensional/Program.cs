using System;

namespace _02_ArrayMultidimensional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] marcas = new string[3, 4];

            marcas[0, 0] ="FIAT";
            marcas[0, 1] = "Chevrolet";
            marcas[0, 2] = "Renault";
            marcas[0, 3] = "Pegeout";

            marcas[1, 0] = "HP";
            marcas[1, 1] = "DELL";
            marcas[1, 2] = "Positivo";
            marcas[1, 3] = "CCE";

            string[,] nomes = new string[,] { { "FIAT", "Chevrolet" }, { "HP", "DELL" }, { "LG" , "Samsung" } };

        }
    }
}
