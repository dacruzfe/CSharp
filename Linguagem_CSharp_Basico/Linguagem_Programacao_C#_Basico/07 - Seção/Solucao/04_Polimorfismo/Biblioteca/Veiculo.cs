using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Polimorfismo.Biblioteca
{
    class Veiculo
    {
        public string Marca;
        public string Modelo;
        public string Ano;
        
        public virtual void Mover()
        {
            Console.WriteLine("Veiculo se movendo!!!!!!");
        }
    }
}
