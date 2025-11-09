using Triangulo;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Triangle x, y;
        x = new Triangle();
        y = new Triangle();
        Console.WriteLine("Enter the measures of triangle X:");
        x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine("Enter the measures of triangle Y:");
        y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double areaX = x.Area();
        double areaY = y.Area();
        Console.WriteLine($"Triangle X area: {areaX:F4}");
        Console.WriteLine($"Triangle Y area: {areaY:F4}");
        if (areaX > areaY)
        {
            Console.WriteLine("Larger area: X");
        }
        else
        {
            Console.WriteLine("Larger area: Y");
        }
    }
}