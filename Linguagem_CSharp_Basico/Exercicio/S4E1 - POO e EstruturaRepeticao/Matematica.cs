using System;
using System.Collections.Generic;
using System.Text;

namespace S4E1___POO_e_EstruturaRepeticao
{
    class Matematica
    {
        public static int Exponenciacao(int Base, int Exp)
        {
            int Resultado = Base;
            for (int i = 1; i < Exp; i++)
            {
                Resultado = Resultado * Base;
            }
            return Resultado;
        }
    }
}
