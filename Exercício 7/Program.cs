using System;

class Program
{
    static void Main()
    {
        int[] R = new int[5]; // Vetor do gabarito da LOTO
        int[] A = new int[10]; // Vetor da aposta
        int pontos = 0;

        Console.WriteLine("Digite os 5 números do gabarito da LOTO:");
        for (int i = 0; i < R.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            R[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nDigite os 10 números da aposta:");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write($"Número {i + 1}: ");
            A[i] = int.Parse(Console.ReadLine());
        }

        // Verifica quantos números da aposta estão no gabarito
        foreach (int numAposta in A)
        {
            foreach (int numGabarito in R)
            {
                if (numAposta == numGabarito)
                {
                    pontos++;
                    break; // Evita contar mais de uma vez o mesmo número
                }
            }
        }

        Console.WriteLine($"\nO apostador fez {pontos} pontos!");
    }
}
