using System;
using System.Globalization;

namespace EntradaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // O comando Parse converte string em inteiro
            int n1 = int.Parse(Console.ReadLine());

            // Converte string em char
            char ch = char.Parse(Console.ReadLine());

            // Converte string em Double o cultureinfo InvarianteCulture serve para corrigir quando escrevo numeros com pontos.
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
 
            Console.WriteLine("Você digitou!");
            Console.WriteLine(n1);
            Console.WriteLine(ch);
            // O F2 é um delimitador de casas decimais 
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
