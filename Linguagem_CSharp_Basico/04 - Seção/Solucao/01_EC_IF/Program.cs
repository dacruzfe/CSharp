using System;

namespace _01_EC_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            string valorPoupancaTexto;
            float valorPoupanca;
            Console.Write("Digite o valor que você possui na conta poupança: ");
            valorPoupancaTexto = Console.ReadLine();
            valorPoupanca = float.Parse(valorPoupancaTexto);

            if ( valorPoupanca > 100000 )
            {
                Console.WriteLine("Você cliente VIP possui uma taxa de juros diferenciada. ");
            }
            else if ( valorPoupanca > 50000)
            {
                Console.WriteLine("Você está quase lá amigo, não desista, continue investindo, principalmente em conhecimento!");
            }
            else
            {
                Console.WriteLine("Você é pobre, mas continue investindo, principalmente em conhecimento! ");
            }
 
            Console.ReadKey();
        }
    }
}
