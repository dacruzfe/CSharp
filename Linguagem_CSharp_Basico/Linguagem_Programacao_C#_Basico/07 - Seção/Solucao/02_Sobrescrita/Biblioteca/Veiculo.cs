using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Sobrescrita.Biblioteca
{
    class Veiculo
    {
        public string Marca;
        public string Modelo;
        public int QuantidadeMaximaPassageiros;
        public int Ano;


        public virtual void Mover()
        {
            Console.WriteLine("Mover chamado dentro de: Veiculo.Mover");
        }
    }
}
