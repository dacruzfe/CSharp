

string aluno = "Heloisa";


//if (aluno == "Felipe")
//{
//    Console.WriteLine("O nome do aluno é igual a Daniel");
//}
//else if (aluno == "Daniel")
//{  
//    Console.WriteLine("O nome do Aluno é diferente de Daniel"); 
//}
//else if (aluno == "Heloisa")
//{
//    Console.WriteLine("O nome do Aluno é igual a Daniel");
//}
//else
//{
//    Console.WriteLine("O nome do Aluno é diferente de Daniel e Ricardo");
//}


switch (aluno)
{
    case "Ricardo":
        Console.WriteLine("O nome do aluno é igual a Ricardo");
        break;
    case "Daniel":
        Console.WriteLine("O nome do aluno é igual a Daniel");
        break;
    case "Manu":
        Console.WriteLine("O nome do aluno é igual a Manu");
        break;
    case "Heloisa":
        Console.WriteLine("O nome do aluno é igual a Heloisa");
        break;
    default:
        Console.WriteLine("O nome do Aluno é diferente de Daniel e Ricardo");
        break;
}

Console.ReadKey();