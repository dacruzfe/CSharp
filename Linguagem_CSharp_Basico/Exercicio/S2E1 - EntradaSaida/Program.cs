using System;

namespace S2E1___EntradaSaida
{
    class Program
    {
        static void Main(string[] args)
        {


            string EntradaNome, EntradaIdade;
            
            Console.WriteLine("Digite seu Nome: ");
            EntradaNome = Console.ReadLine();
            Console.WriteLine("Digite sua idade: ");
            EntradaIdade = Console.ReadLine();

            int IdadeNumero = int.Parse(EntradaIdade);
            int AnoNascimento = DateTime.Now.Year - IdadeNumero;

            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("Seu nome é: " + EntradaNome);
            Console.WriteLine("O ano aproximado de nascimento é: " + AnoNascimento);

            Console.ReadKey();
        }
    }
}
