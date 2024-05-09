using System;

namespace _02_OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Toda vez que você utiliza o sinal de um operador aritimetico seguido de um igual
             * Significa que você vai ter a operação de um mesmo valor existente na variavel mais o valor seguinte
             * Ou menos o valor seguinte ou multiplicado o valor seguinte ou dividido ou o resto do valor seguinte
             */ 

            int valorA = 10;
            valorA += 10;
            valorA -= 10;
            valorA *= 3;
            valorA /= 3;
            valorA %= 4;
                
            valorA = valorA + 10;
            valorA = valorA - 10;
            valorA = valorA * 10;
            valorA = valorA / 10;
            valorA = valorA % 10;


            Console.WriteLine(valorA);
        }
    }
}
