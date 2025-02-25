using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de horas trabalhadas no mês: ");
        int horasTrabalhadas = int.Parse(Console.ReadLine());

        Console.Write("Digite o salário por hora: ");
        double salarioHora = double.Parse(Console.ReadLine());

        
        int horasSemanais = 40;
        int semanasNoMes = 4;
        int horasNormais = horasSemanais * semanasNoMes;

        double salarioTotal;

        
        if (horasTrabalhadas > horasNormais)
        {
            int horasExtras = horasTrabalhadas - horasNormais;
            double valorHoraExtra = salarioHora * 1.5; 
            salarioTotal = (horasNormais * salarioHora) + (horasExtras * valorHoraExtra);
        }
        else
        {
            salarioTotal = horasTrabalhadas * salarioHora;
        }

       
        Console.WriteLine($"O salário total do funcionário é: R$ {salarioTotal:F2}");
    }
}
