﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Polimorfismo.Biblioteca.Derivada
{
    class Moto : Veiculo
    {
        public override void Mover()
        {
            Console.WriteLine("Moto se movendo!!!!!!");
        }
    }
}
