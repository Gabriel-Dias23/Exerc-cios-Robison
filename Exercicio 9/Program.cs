using System;
using System.Linq;

class Program
{
    static void Main()
    {
        double[] notas = new double[6]; // Vetor para armazenar as 6 notas dos juízes

        Console.WriteLine("Digite as 6 notas dos juízes (valores entre 0 e 10):");

        // Leitura das notas
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }

        // Encontrar a maior e a menor nota
        double maior = notas.Max();
        double menor = notas.Min();

        // Calcular a soma excluindo a maior e a menor nota
        double soma = notas.Sum() - maior - menor;

        // Exibir o resultado final
        Console.WriteLine($"\nNota final do atleta (excluindo maior e menor nota): {soma:F2}");
    }
}
