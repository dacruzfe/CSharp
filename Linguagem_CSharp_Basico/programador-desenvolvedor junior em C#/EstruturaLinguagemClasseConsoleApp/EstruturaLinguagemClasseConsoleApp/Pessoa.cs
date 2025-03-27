using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstruturaLinguagemClasseConsoleApp
{
    public struct Pessoa
    {
        public Pessoa(int idade, string nome, SexoEnum sexo)
        {
            this.idade = idade;
            this.nome = nome;
            this.sexo = sexo;
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public string nome;
        int idade;
        public SexoEnum sexo;

        public enum SexoEnum
        {
            F,
            M
        }

        public void CalcularIdade(DateTime dataNascimento)
        {
            if (dataNascimento == DateTime.MinValue)
                throw new DataNascimentoObrigatorioException();
            idade = DateTime.Now.Year - dataNascimento.Year;
        }

        public int ObterIdade()
        {
            return idade;
        }
    }
}
