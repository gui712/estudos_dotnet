using System.Globalization;
using MembrosEstaticos;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Static Members in C#");
        Console.WriteLine("Enter the radius of the circle:");
        double radius = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circ = Calculator.Circunference(radius);
        double vol = Calculator.Volume(radius);
        Console.WriteLine("Circumference: " + circ.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Volume: " + vol.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Value of PI: " + Calculator.PI.ToString("F2", CultureInfo.InvariantCulture));
    }

    
}