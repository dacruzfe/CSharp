using System;

namespace _04_OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Existem basicamente dois operadores lógicos o primeiro é o e comercial & e
            // o segundo é o piper que é nada mais do que aquela barrinha totalmente na vertical
            // que temos no teclado do computador | 

            string sexo = "M";
            int idade = 18;

            // Quando você utiliza apenas um e cormercial você está comparando as duas expressões,
            // Caso as duas forem verdadeiras ele mostrará um resultado, ele comparara a duas obrigatóriamente
            if ( sexo == "M" & idade == 18)
            {
                Console.WriteLine("Deve se alistar");
            }

            if ( 10 == 10 & 10 > 9)
            {

            }

            if ( 10 == 10 | 10 == 9)
            {

            }

            if (sexo == "M" || (sexo == "F" & idade ==  18))
            {
                Console.WriteLine("Condição com expressões isoladas");
            }


            /* No caso de dois e comerciais ele compara a primeira expressão
             * Se ela se provar falsa ele não compara a segunda
             * ou seja se uma expressão for falsa ele ja sabe que toda expressão vai ser falsa
             */
            if (10 == 10 && 10 > 9)
            {

            }
            /* A mesma coisa no Ou se ele ja sabe que a primeira expressão é verdadeira 
             * Ele já assume que toda a expressão é verdadeira
             */
            if (10 == 10 || 10 == 9)
            {

            }


            Console.WriteLine("Operadores Lógicos!");
        }
    }
}
