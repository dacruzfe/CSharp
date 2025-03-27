//Classe é uma abstração de objetos que contem ou não comportamentos e funcionalidades


//Pessoa aluno = new Pessoa();
//Pessoa aluno2 = new Pessoa();

//aluno.idade = 40;
//aluno.nome = "Felipe";
//aluno.sexo = 'M';

//aluno2.idade = 5;
//aluno2.nome = "Bernardo";
//aluno2.sexo = 'M';

//Console.WriteLine(aluno.nome);
//Console.WriteLine(aluno.sexo);
//Console.WriteLine("----------------");
//Console.WriteLine(aluno2.nome);
//Console.WriteLine(aluno2.sexo);

using EstruturaLinguagemClasseConsoleApp;

//Pessoa aluno = new Pessoa();
//aluno.nome = "Felipe";

//aluno.CalcularIdade(Convert.ToDateTime("1984-06-26"));

//Console.WriteLine($"A idade é: {aluno.ObterIdade}");

//var aluno = new Pessoa();
//aluno.sexo = Pessoa.SexoEnum.M;
//aluno.nome = "Sandro";

Pessoa aluno = new Pessoa("Pedro");

try
{

    Console.WriteLine($"Antes de chamar o método: {aluno.nome}");

    AlterarNome(aluno);
    aluno.CalcularIdade(DateTime.MinValue.AddYears(2020));
    ValidarIdadeMaior18(aluno);
    Console.WriteLine($"Depois de chamar o método: {aluno.nome}");
}
catch (MenorIdadeException ex)
{
    Console.WriteLine($"Deu o meu erro {ex.Message}");
    throw;
}
catch (DataNascimentoObrigatorioException ex)
{
    Console.WriteLine($"Deu o meu erro {ex.Message}");
    throw;
}
catch (Exception batatinha)
{
    Console.WriteLine($"Deu erro {batatinha.Message}");
    throw new Exception( "Opa, deu erro!" );
}
finally
{
    Console.WriteLine("Fim no Finally!");
}
void AlterarNome(Pessoa pessoa)
{
    pessoa.nome = "João";
    Console.WriteLine($"Dentro do método: {pessoa.nome}");
}

void ValidarIdadeMaior18(Pessoa aluno)
{
    if (aluno.ObterIdade() < 18)
        throw new MenorIdadeException();
}

Console.WriteLine("Fim do Fim!");

Console.ReadKey();

//Metodos são ações dentro de uma classe, então essa classe pode ter varias funcionalidade.