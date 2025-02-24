double altura;
char genero;
double pesoidealH;
double pesoidealM;

Console.WriteLine("Digite sua altura: ");
altura = double.Parse(Console.ReadLine());
Console.WriteLine("Digite seu gênero (H/M): ");
genero = char.Parse(Console.ReadLine());

pesoidealH = (72.7 * altura) - 58;
pesoidealM = (62.1 * altura) - 44.7;

if (genero == 'H' || genero == 'h')
{
    Console.WriteLine("Seu peso ideal é: ");
    Console.WriteLine(pesoidealH);
}

else if (genero == 'M' || genero == 'm')
{
    Console.WriteLine("Seu peso ideal é: ");
    Console.WriteLine(pesoidealM);
}

else 
    {
    Console.WriteLine("Gênero Inválido!");
}