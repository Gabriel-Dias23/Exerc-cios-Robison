using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Responda com 'sim' ou 'não' para as perguntas a seguir.");

        // Primeira pergunta: Mamífero ou Ave?
        Console.Write("É mamífero? ");
        string resposta = Console.ReadLine().ToLower();

        if (resposta == "sim")

        {
            Console.Write("É quadrúpede? ");
            resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
                Console.Write("É carnívoro? ");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "sim")
                {
                    Console.WriteLine("O animal escolhido foi o leão.");
                }
                else
                {
                    Console.Write("É herbívoro? ");
                    resposta = Console.ReadLine().ToLower();

                    if (resposta == "sim")
                    {
                        Console.WriteLine("O animal escolhido foi o cavalo.");
                    }
                }
            }
            else
            {
                Console.Write("É bípede? ");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "sim")
                {
                    Console.Write("É onívoro? ");
                    resposta = Console.ReadLine().ToLower();

                    if (resposta == "sim")
                    {
                        Console.WriteLine("O animal escolhido foi o homem.");
                    }
                    else
                    {
                        Console.WriteLine("O animal escolhido foi o macaco.");
                    }
                }
                else
                {
                    Console.Write("É voador? ");
                    resposta = Console.ReadLine().ToLower();

                    if (resposta == "sim")
                    {
                        Console.WriteLine("O animal escolhido foi o morcego.");
                    }
                    else
                    {
                        Console.WriteLine("O animal escolhido foi a baleia.");
                    }
                }
            }
        }
        else
        {
            Console.Write("É uma ave não voadora? ");
            resposta = Console.ReadLine().ToLower();

            if (resposta == "sim")
            {
                Console.Write("Vive em região tropical? ");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "sim")
                {
                    Console.WriteLine("O animal escolhido foi a avestruz.");
                }
                else
                {
                    Console.WriteLine("O animal escolhido foi o pinguim.");
                }
            }
            else
            {
                Console.Write("É nadadora? ");
                resposta = Console.ReadLine().ToLower();

                if (resposta == "sim")
                {
                    Console.WriteLine("O animal escolhido foi o pato.");
                }
                else
                {
                    Console.WriteLine("O animal escolhido foi a águia.");
                }
            }
        }
    }
}
