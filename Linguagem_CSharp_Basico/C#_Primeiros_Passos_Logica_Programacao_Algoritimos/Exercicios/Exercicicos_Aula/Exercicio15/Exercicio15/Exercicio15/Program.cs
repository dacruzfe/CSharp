using System;

namespace Exercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variavel M e N para armazenar os inteiros para M linhas e N colunas
            int M, N;

            //Aqui o exemplo de declaração da minha Matriz
            int[,] mat;

            //Para armazenar os dados que serão digitados na mesma linha e pegar o que vem depois dos espaços usamos string[] e o split dessa forma
            string[] s = Console.ReadLine().Split(' '); //dessa forma a matriz s recebe o que for digitado no console Readline

            //Agora o M vai receber o conteúdo do Int.Parse na posição zero
            M = int.Parse(s[0]);
            //E o N vai receber o conteúdo do int.Parse na posição 1
            N = int.Parse(s[1]);

            //Aqui faço a matriz receber os valores de M linhas e N colunas
            mat = new int[M, N];

            //Agora um código para percorrer a Matriz linha por linha

            //Enquanto i for menor que a quantidade de linhas que é M então i recebe 1
            for (int i = 0; i < M; i++)
            {
                //Para cada linha dessas a minha string s recebe o conteúdo digitado na console.readline.split baseado no espaço em branco
                s = Console.ReadLine().Split(' ');

                //Aqui outro for para percorrer as colunas 
                //Enquanto j for menor que o numero de colunas que é N j recebe 1
                for (int j = 0; j < N; j++)
                {
                    //Aqui faço meu for falando que a Matriz mat na linha i e na coluna j vai receber o int.parse do vetor s na posição j
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            //Agora vou declarar um vetor e vou instanciar esse vetor com a quantidade de linhas da Matriz
            int[] vet = new int[M];

            //Agora preciso percorrer a minha matriz somando os elementos de cada linha e atribuindo essa soma ao vetor
            for (int i = 0; i < M; i++)
            {
                //Para cada linha da Matriz eu vou iniciar uma váriavel soma com zero;
                int soma = 0;

                //Aora percorro todas as colunas dessa linha fazendo a soma acumulada e essa soma acumulada eu adiciono a variavel soma
                for (int j = 0; j < N; j++)
                {
                    //E para cada coluna eu vou fazer a soma e receber ela mesma na Matriz mat na Linha i e coluna J
                    soma = soma + mat[i, j];
                }
                vet[i] = soma;
            }

            //Agora um for para imprimir o vetor vet
            for (int i = 0; i < M; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.ReadLine();
        }
    }
}
