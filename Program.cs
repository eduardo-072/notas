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
