//- Um supermercado deseja reajustar os preços de seus produtos usando o
//seguinte critério: o produto poderá ter seu preço aumentado ou diminuído. Para
//alterar o preço o produto deve preencher os requisitos indicados por cada uma das
//linhas a seguir, isto é, atender tanto a venda média mensal quanto o preço atual:

using System;

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int VendaMediaMensal { get; set; }

    public void ReajustarPreco()
    {
        if (VendaMediaMensal < 500 && Preco < 30)
        {
            Preco *= 1.10; // Aumento de 10%
        }
        else if (VendaMediaMensal >= 500 && Preco >= 30)
        {
            Preco *= 0.80; // Redução de 20%
        }
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto();

        Console.Write("Nome do produto: ");
        produto.Nome = Console.ReadLine();

        Console.Write("Preço atual: ");
        produto.Preco = Convert.ToDouble(Console.ReadLine());

        Console.Write("Venda média mensal: ");
        produto.VendaMediaMensal = Convert.ToInt32(Console.ReadLine());

        produto.ReajustarPreco();

        Console.WriteLine($"Novo preço do produto {produto.Nome}: {produto.Preco:F2}");
    }
}
