using System.Globalization;
using System.Security.Principal;

Console.WriteLine("Digite nota do aluno!!");

var nota = Convert.ToDouble(Console.ReadLine());


if (nota < 5)
{

    Console.WriteLine("ALUNO REPROVADO");
}

else if (nota >= 5 && nota < 6)
{
    Console.WriteLine("Aluno Recuperação!!");
}

else if (nota >= 6 && nota <= 9)
{

    Console.WriteLine("ALUNO APROVADO!");
}

else if (nota > 9)
{
    Console.WriteLine("ALUNO APROVADO!! PARABÉNS!!!");
}
Console.WriteLine("Fim do Processamento.....");
Console.ReadKey();