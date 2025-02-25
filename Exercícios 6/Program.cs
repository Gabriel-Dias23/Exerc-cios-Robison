using System;

class Program
{
    static void Main()
    {
        double S = 0;
        int numerador = 1; // Primeiro número ímpar

        Console.WriteLine("Processo de cálculo da soma S:");

        for (int denominador = 1; denominador <= 50; denominador++)
        {
            double termo = (double)numerador / denominador;
            S += termo;

            // Exibir o termo atual da soma
            Console.WriteLine($"{numerador}/{denominador} = {termo:F4} -> Soma parcial: {S:F4}");

            numerador += 2; // Próximo número ímpar
        }

        Console.WriteLine($"\nO valor final de S é: {S:F4}");
    }
}
