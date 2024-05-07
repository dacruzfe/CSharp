using System;

namespace _04_Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            /// NO Polimorfismo eu posso simplesmente ter uma entrada da classe base e se a classe base no caso a veiculo tiver um método chamado mover
            /// E ao invés de receber a classe veiculo ele receber uma classe derivada eu vou chamar o método da classe derivada.
            /// Assim que funciona o Polimorfismo, nós temos uma classe que gera várias outras, que tem varias formas, mas nos podemos usar a classe base
            /// Como parametro para chamar métodos especificos
            /// </summary>
            Biblioteca.Derivada.Moto moto = new Biblioteca.Derivada.Moto();
            MoverVeiculo(moto);

            Biblioteca.Derivada.Carro carro = new Biblioteca.Derivada.Carro();
            MoverVeiculo(carro);


            Console.ReadKey();

            
        }

        public static void MoverVeiculo(Biblioteca.Veiculo veiculo)
        {
            veiculo.Mover();
        }
    }
}
