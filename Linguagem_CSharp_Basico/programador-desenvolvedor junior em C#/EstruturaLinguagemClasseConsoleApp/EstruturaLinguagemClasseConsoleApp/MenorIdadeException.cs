using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaLinguagemClasseConsoleApp
{
    public class MenorIdadeException : Exception
    {
        public MenorIdadeException() : base("Aluno deve ter 18 anos!") 
        { 
         
        }
    }
}
