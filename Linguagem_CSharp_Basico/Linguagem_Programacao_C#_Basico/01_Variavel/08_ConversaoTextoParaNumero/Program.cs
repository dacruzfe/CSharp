using System;

namespace _08_ConversaoTextoParaNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            string NumeroTexto = "30";
            int Numero1 = int.Parse(NumeroTexto);
            int Numero2 = 30 ;


            Console.Write("O Resultado da soma é: " + (Numero1 + Numero2));

            Console.Write("\n" + "Soma de 2 Números convertendo uma String em número!");
            Console.ReadKey();
        }
    }
}
