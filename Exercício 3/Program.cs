using static System.Runtime.InteropServices.JavaScript.JSType;

int escolha;

Console.WriteLine("Digite um numero para o número para o dia da semana: ");
    escolha = int.Parse(Console.ReadLine());
do
{
    if (escolha == 1)
    {
        Console.WriteLine("Domingo");
    }

    else if (escolha == 2)
    {
        Console.WriteLine("Segunda");
    }

    else if (escolha == 3)
    {
        Console.WriteLine("Terça");
    }

    else if (escolha == 4)
    {
        Console.WriteLine("Quarta");
    }

    else if (escolha == 5)
    {
        Console.WriteLine("Quinta");
    }

    else if (escolha == 6)
    {
        Console.WriteLine("Sexta");
    }

    else if (escolha == 7)
    {
        Console.WriteLine("Sábado");
    }


    escolha = int.Parse(Console.ReadLine());
}


 while (escolha != 0);

Console.WriteLine("Programa encerrado.");