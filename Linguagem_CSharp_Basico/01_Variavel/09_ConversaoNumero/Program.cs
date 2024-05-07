using System;

namespace _09_ConversaoNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            short meuShort = 10;
            int meuInt = meuShort;
            long meuLong = meuInt;


            long meuLong2 = 10;
            int meuInt2 = Convert.ToInt32(meuLong2);
            short meuShort2 = Convert.ToInt16(meuInt2);

            Console.Write("Convertendo números entre os tipos primitivos");
            Console.ReadKey();
        }
    }
}
