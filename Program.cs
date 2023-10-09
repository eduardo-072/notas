double n1;
double n2;
double n3;
double n4;
double media;

string resultado;


Console.Write("------MÉDIA DE NOTAS------\n");
Console.WriteLine("DIGITE SUA NOTA\n");

Console.Write("NOTA1: ");
n1 = Convert.ToDouble(Console.ReadLine());

Console.Write("NOTA2: ");
n2 = Convert.ToDouble(Console.ReadLine());

Console.Write("NOTA3: ");
n3 = Convert.ToDouble(Console.ReadLine());

Console.Write("NOTA4: ");
n4 = Convert.ToDouble(Console.ReadLine());

Console.Write("");

if (n1 < 0 || n1 > 10
|| n2 < 0  || n2 > 10
|| n3 < 0  || n3 > 10
|| n4 < 0  || n4 > 10)
{
    Console.WriteLine("DIGITE APENAS NOTAS DE 0 A 10.");
}
else
{
    media = (n1 + n2 + n3 + n4) / 4;

    if (media < 5)
    {
        resultado = "REPROVADO!";
    }
    else if (media > 6)
    {
         resultado = "APROVADO!";
    }
        
     else 
    {
        resultado = "VOCÊ ESTÁ DE RECUPERAÇÃO!!!"; 
    }

    Console.WriteLine($"Você ficou com média {media:N1}. Resultado: {resultado}");

}







// ﻿double n1, n2, n3, n4, media;
// string resultado;

// Console.WriteLine("-- Média --\n");
// Console.WriteLine("Digite as suas notas abaixo.");

// Console.Write("Nota 1: ");
// n1 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Nota 2: ");
// n2 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Nota 3: ");
// n3 = Convert.ToDouble(Console.ReadLine());

// Console.Write("Nota 4: ");
// n4 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine();

// if (n1 < 0 || n1 > 10
//  || n2 < 0 || n2 > 10
//  || n3 < 0 || n3 > 10
//  || n4 < 0 || n4 > 10)
// {
//     Console.WriteLine("Digite somente notas entre 0 e 10.");
// }
// else
// {
//     media = (n1 + n2 + n3 + n4) / 4;

//     if (media < 5)
//     {
//         resultado = "Reprovado";
//     }
//     else if (media > 6)
//     {
//         resultado = "Aprovado";
//     }
//     else
//     {
//         resultado = "Em recuperação";
//     }

//     Console.WriteLine($"Você ficou com média {media:N1}. Resultado: {resultado}");
// }