using System;

namespace _02_EC_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu estado civil? (Informe: S - Solteiro, C - Casado, V - viuvo, D - Divorciado)");
            string valor = Console.ReadLine();
            switch (valor)
            {
                case "S":
                    Console.WriteLine("Você está solteiro, parabéns você é um sortudo!");
                    break;
                case "C":
                    Console.WriteLine("Você está Casado, Boa Sorte, você vai precisar!");
                    break;
                case "V":
                    Console.WriteLine("Você está Viuvo, parabéns você é um sortudo e agora está liberto da prisão!");
                    break;
                case "D":
                    Console.WriteLine("Você está Divorciado, parabéns você passou por um livramento e agora está quebrado!");
                    break;

                default:
                    Console.WriteLine("Comando não reconhecido");
                    break;
            }
            Console.ReadKey();
        }
    }
}
