using System;

class Program
{
    static void Main()
    {
        int[] D = new int[20];
        int[] compactado = new int[20];
        int count = 0; 

        Console.WriteLine("Digite 20 números inteiros:");

        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Elemento {i + 1}: ");
            D[i] = int.Parse(Console.ReadLine()); 
        }

      
        Console.Write("Digite o valor de N: ");
        int N = int.Parse(Console.ReadLine());

    
        for (int i = 0; i < 20; i++)
        {
            if (D[i] > N) 
            {
                compactado[count] = D[i]; 
                count++; 
            }
        }

     
        Console.Write("Vetor compactado (elementos maiores que N): ");
        for (int i = 0; i < count; i++)
        {
            Console.Write(compactado[i]);
            if (i < count - 1) 
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

