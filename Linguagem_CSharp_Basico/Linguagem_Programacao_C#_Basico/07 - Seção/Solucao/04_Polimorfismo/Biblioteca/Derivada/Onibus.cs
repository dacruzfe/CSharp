﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Polimorfismo.Biblioteca.Derivada
{
    class Onibus : Veiculo
    {
        public override void Mover()
        {
          Console.WriteLine("Onibus se movendo!!!!!!");
        }
    }
}
