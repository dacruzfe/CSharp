using System;
using System.Globalization;

namespace uri1005
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aqui estamos declarando três variáveis do tipo double: A, B e media. A e B são as notas do aluno e media será a média calculada.
            double A, B, media;

            /* Estas linhas leem os valores de entrada do usuário, utilizando Console.ReadLine(), 
             * e convertem esses valores para o tipo double utilizando double.Parse(). CultureInfo.InvariantCulture é usado para garantir que o ponto seja reconhecido como separador decimal,
             * independentemente da configuração regional do sistema. */
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /*Aqui calculamos a média ponderada do aluno, conforme especificado no problema. A nota A tem peso 3.5 e a nota B tem peso 7.5,
             * então somamos o produto de cada nota pelo seu peso e dividimos pela soma dos pesos. */
            media = ((A * 3.5) + (B * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("F5", CultureInfo.InvariantCulture));
        }
    }
}
