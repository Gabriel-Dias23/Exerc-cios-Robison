using System;

class Program
{
    static void Main()
    {
        double[] notas = new double[6];

       
        Console.WriteLine("Digite as 6 notas dos juízes (de 0 a 10):");
        for (int i = 0; i < 6; i++)
        {
            Console.Write($"Nota {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());

     
            while (notas[i] < 0 || notas[i] > 10)
            {
                Console.Write("Nota inválida! Digite um valor entre 0 e 10: ");
                notas[i] = double.Parse(Console.ReadLine());
            }
        }

        double maior = notas[0], menor = notas[0], somaTotal = 0;

        for (int i = 0; i < 6; i++)
        {
            if (notas[i] > maior)
                maior = notas[i];

            if (notas[i] < menor)
                menor = notas[i];

            somaTotal += notas[i]; 
        }

      
        double notaFinal = somaTotal - maior - menor;

        Console.WriteLine($"\nMaior nota descartada: {maior}");
        Console.WriteLine($"Menor nota descartada: {menor}");
        Console.WriteLine($"Nota final do atleta: {notaFinal:F2}");
    }
}
