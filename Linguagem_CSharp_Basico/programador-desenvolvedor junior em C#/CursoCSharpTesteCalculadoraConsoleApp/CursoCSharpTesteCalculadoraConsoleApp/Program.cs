Console.WriteLine("Seja Bem Vindo a Calculadora!");
//Receber 2 valores
//Solicitar os dois valores para o usuário digitar
Console.WriteLine("Digite o primeiro valor:");
string? primeiroValorString = Console.ReadLine();
double primeiroValor = Convert.ToDouble(primeiroValorString);


Console.WriteLine("Digite o segundo valor:");
string? segundoValorString = Console.ReadLine();
double segundoValor = Convert.ToDouble(segundoValorString);

//Dar opções de calculo
Console.WriteLine("Selecione a operação:");
Console.WriteLine("+");
Console.WriteLine("-");
Console.WriteLine("*");
Console.WriteLine("/");

var operacaoSelecionada = Console.ReadLine();

//Realizar o calculo

double resultadoOperacao;  
switch (operacaoSelecionada)
{
    case "+":
        resultadoOperacao = primeiroValor + segundoValor;
        Console.WriteLine($"Resultado da operacao: {resultadoOperacao}");
        break;
    case "-":
        resultadoOperacao = primeiroValor - segundoValor;
        Console.WriteLine($"Resultado da operacao: {resultadoOperacao}");
        break;
    case "*":
        resultadoOperacao = primeiroValor * segundoValor;
        Console.WriteLine($"Resultado da operacao: {resultadoOperacao}");
        break;
    case "/":
        resultadoOperacao = primeiroValor / segundoValor;
        Console.WriteLine($"Resultado da operacao: {resultadoOperacao}");
        break;
    default:
        Console.WriteLine("Operação inválida!");
        break;
}

//Exibir o resultado
//Finalizar a aplicação

Console.ReadKey();