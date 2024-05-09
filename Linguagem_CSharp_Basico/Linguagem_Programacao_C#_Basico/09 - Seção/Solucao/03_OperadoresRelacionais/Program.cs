using System;

namespace _03_OperadoresRelacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // O operador que verifica igualdade é igual igual essa expressão retorna o resultado de forma booleana true ou false
            Console.WriteLine(10 == 10); //True
            Console.WriteLine(11 == 10); //False

            if (10 == 10)
            {
                Console.WriteLine("10 é igual a 10");
            }

            Console.WriteLine(10 > 9);
            Console.WriteLine(10 < 9);

            Console.WriteLine(10 >= 9);
            Console.WriteLine(10 <= 9);

            // toda vez que o ponto de exclamação é empregado significa que ele está negando o valor ou a expressão existente
            Console.WriteLine(10 != 9);

            Console.WriteLine( !(10 == 10) );


            Console.ReadKey();
        }
    }
}
