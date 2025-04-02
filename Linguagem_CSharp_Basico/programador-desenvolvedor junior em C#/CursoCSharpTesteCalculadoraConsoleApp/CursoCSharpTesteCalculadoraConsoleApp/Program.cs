using CursoCSharpTesteCalculadoraConsoleApp;

Console.WriteLine("Seja Bem Vindo a Calculadora!");

try
{
    Calculadora calculadora = new Calculadora();
    calculadora.Executar();
}
catch (Exception ex)
{
    Console.Clear();
    Console.WriteLine("Deu erro, Não consegui realizar o processo!!!");
}

Console.WriteLine();
Console.WriteLine("Até logo!!");

Console.ReadKey();