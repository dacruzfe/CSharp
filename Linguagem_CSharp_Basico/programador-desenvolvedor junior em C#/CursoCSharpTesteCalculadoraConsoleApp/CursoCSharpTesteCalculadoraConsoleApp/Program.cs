Console.WriteLine("Seja Bem Vindo a Calculadora!");

do
{
    Console.Clear();
    Console.WriteLine("Digite o primeiro valor:");
    string? primeiroValorString = Console.ReadLine();
    double primeiroValor = Convert.ToDouble(primeiroValorString);


    Console.WriteLine("Digite o segundo valor:");
    string? segundoValorString = Console.ReadLine();
    double segundoValor = Convert.ToDouble(segundoValorString);

    Console.WriteLine("Selecione a operação:");
    Console.WriteLine("+");
    Console.WriteLine("-");
    Console.WriteLine("*");
    Console.WriteLine("/");

    var operacaoSelecionada = Console.ReadLine();

    double? resultadoOperacao;
    switch (operacaoSelecionada)
    {
        case "+":
            resultadoOperacao = primeiroValor + segundoValor;
            break;
        case "-":
            resultadoOperacao = primeiroValor - segundoValor;
            break;
        case "*":
            resultadoOperacao = primeiroValor * segundoValor;
            break;
        case "/":
            resultadoOperacao = primeiroValor / segundoValor;
            break;
        default:
            resultadoOperacao = null;
            break;
    }

    //if (resultadoOperacao.HasValue)
    //    Console.WriteLine($"Resultado da operacao: {resultadoOperacao}");
    //else
    //    Console.WriteLine("Operação inválida!");

    Console.WriteLine();
    var mensagem = resultadoOperacao.HasValue ? $"Resultado da operação: {resultadoOperacao}" : "Operação inválida!";
    Console.WriteLine(mensagem);


    Console.WriteLine();
    Console.WriteLine("Deseja realizar outra operação?");
    Console.WriteLine("(S) Sim (N) Não");
} while (Console.ReadKey().Key == ConsoleKey.S);

Console.WriteLine("Até logo!!");

Console.ReadKey();