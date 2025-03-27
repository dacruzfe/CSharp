Console.WriteLine("Tipos de Operadores");


string nome = "Felipe";

string sobrenome = "Cruz";

Console.WriteLine($"{nome} {sobrenome}");

int idade = 0;

//idade = idade + 40;
idade += 40;

//idade -= 15;

//idade = idade * 2;
//idade *= 2;
//idade = idade / 2;
//idade /= 2;
//idade = idade % 2;
//idade %= 2;

//bool resultado = idade == 36;
//bool resultado = idade >= 36;
//bool resultado = idade > 36;
//bool resultado = idade <= 30;
//bool resultado = idade != 40 && idade > 10 || idade == 40;
bool resultado = !(idade == 40);

Console.WriteLine(resultado);

Console.ReadKey();  