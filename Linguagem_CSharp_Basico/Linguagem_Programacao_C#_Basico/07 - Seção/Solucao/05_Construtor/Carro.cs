using System;
using System.Collections.Generic;
using System.Text;

namespace _05_Construtor
{
    class Carro
    {
        /// <summary>
        /// Métodos construtores da classe Carro
        /// </summary>
        public string Marca;
        public string Modelo;
        public int Ano;

        // É necessário construir esse construtor padrão mesmo que ele não tenha nenhuma implementação
        public Carro()
        {
            Marca = "FIAT";
            Modelo = "Palio";
            Ano = 2007;
        }
        public Carro(string Marca, string Modelo, int ano)
        {
            this.Marca = Marca;
            this.Modelo = Modelo;

            //Ano Maiusculo é a propriedade e o ano minusculo é a variavel de entrada.
            Ano = ano;
        }
    }
}
