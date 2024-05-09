using System;

namespace _02_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");

            try
            {
                int numero = int.Parse(Console.ReadLine());
                int num = int.Parse(null);
            }
            catch (FormatException e)
            {

                Console.WriteLine("Não foi localizado número na frase!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Tratado pela classe Pai - Exception");
            }
            finally
            {
                Console.WriteLine("O código que tiver o Finally sempre irá executar o Finally");
            }
          
            Console.ReadKey();
        }
    }
}
