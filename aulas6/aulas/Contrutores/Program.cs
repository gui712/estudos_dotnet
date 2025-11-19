using Contrutores;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Lesson about Constructors");

        Console.WriteLine("Enter product data:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Price: ");
        double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantity in stock: ");
        int quantity = int.Parse(Console.ReadLine());
        Product p = new Product(name, price, quantity);
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