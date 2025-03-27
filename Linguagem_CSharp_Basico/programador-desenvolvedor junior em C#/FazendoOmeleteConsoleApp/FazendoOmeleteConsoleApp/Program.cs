int caixaOvos = 30;

Console.WriteLine($"Minha caixa Contem {caixaOvos} ovos");
for (int i = 0; i < 2; i++)
{
    Console.WriteLine("Pegando 1 ovo da caixa");
    caixaOvos--;
}
Console.WriteLine($"Minha caixa Contem {caixaOvos} ovos");

DateTime final = DateTime.Now.AddSeconds(5);

while ( DateTime.Now < final) 
{
    Console.WriteLine("Fazendo omelete");
    Task.Delay(1000).Wait();
}

Console.WriteLine("Omelete pronta");

Console.ReadKey();  
