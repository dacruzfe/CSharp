using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Sobrescrita.Biblioteca
{
    class Moto : Veiculo
    {
        public int Rodas = 2;
        public override void Mover()
        {
            Console.WriteLine("Mover chamado dentro de: Moto.Mover");
            base.Mover();
        }
    }
}
