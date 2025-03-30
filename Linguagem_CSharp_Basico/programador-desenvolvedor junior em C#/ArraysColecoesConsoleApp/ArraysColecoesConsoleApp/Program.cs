
Console.WriteLine("Hello, Array!");

//var alunos = new string[3] ;
//var alunos = new string[] { "Pedro", "Maria", "Joao" };
//int[] alunos = new int[] {1, 2, 3};

var alunos = new List<string>();
//List<string> alunos = new() { "Pedro", "Joao", "Maria"};
//List<string> alunos = new();

alunos.Add("Pedro");
alunos.Add("Maria");
alunos.Add("Joao");

alunos.Remove("Pedro");
//alunos.Contains("Maria");

foreach (var item in alunos)
    Console.WriteLine(item);

//alunos.Clear();

Console.ReadKey();