using Produto;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Product p = new Product();
        Console.WriteLine("Enter product data:");
        Console.Write("Name: ");
        p.Name = Console.ReadLine();
        Console.Write("Price: ");
        p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantity in stock: ");
        p.Quantity = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Product data: " + p);
        Console.WriteLine();
        Console.Write("Enter the number of products to be added in stock: ");
        int qte = int.Parse(Console.ReadLine());
        p.AddProducts(qte);
        Console.WriteLine();
        Console.WriteLine("Updated data: " + p);
        Console.WriteLine();
        Console.Write("Enter the number of products to be removed from stock: ");
        qte = int.Parse(Console.ReadLine());
        p.RemoveProducts(qte);
        Console.WriteLine();
        Console.WriteLine("Updated data: " + p);
    }
}