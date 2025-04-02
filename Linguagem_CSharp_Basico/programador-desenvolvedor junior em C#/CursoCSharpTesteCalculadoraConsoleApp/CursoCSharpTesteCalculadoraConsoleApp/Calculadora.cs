using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharpTesteCalculadoraConsoleApp
{
    public class Calculadora
    {
        public void Executar()
        {
            do
            {
                Console.Clear();

                double primeiroValor = SolicitarValorComMensagem("Digite o primeiro valor:");
                double segundoValor = SolicitarValorComMensagem("Digite o segundo valor:");

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
        }

        private double SolicitarValorComMensagem(string mensagemSerExibida)
        {
            Console.WriteLine(mensagemSerExibida);
            string? ValorString = Console.ReadLine();
            double valor = Convert.ToDouble(ValorString);
            return valor;
        }
    }
}
