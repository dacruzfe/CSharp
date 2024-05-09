using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Classe.Veiculo
{
    class Carro
    {
        #region Propriedades
        //Propriedades
        public string Marca = "Fiat";
        public string Modelo = "Palio";
        public string Cor = "Preta";
        public bool LuzesInternas = false;
        #endregion

        #region Métodos
        //Métodos
        public void AbrirPorta()
        {
            LuzesInternas = true;
        }
        public void FecharPorta()
        {
            LuzesInternas = false;
        }
        public string AcenderFarolAutomaticamente()
        {
            return "Médio"; 
        }
        #endregion

    }
}
