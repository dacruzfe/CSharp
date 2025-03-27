using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaLinguagemClasseConsoleApp
{
    public class DataNascimentoObrigatorioException : Exception
    {
        public DataNascimentoObrigatorioException() : base("Data de Nascimento é obrigatorio!") 
        { 
         
        }
    }
}
