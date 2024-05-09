using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Sobrecarga
{
    class Pessoa
    {
        // Metodo andar sem parametro, cada metodo deve ter um nome unico
        public int Andar()
        {
            return 1;
        }

        // Método andar com parametro
        public int Andar(int lvl)
        {
            return 1;
        }

        public int Correr()
        {
            return Andar() * 2;
        }
        public int Pedalar()
        {
            return Andar() * 4;
        }
    }
}
