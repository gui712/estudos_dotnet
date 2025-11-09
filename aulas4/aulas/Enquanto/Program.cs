using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
internal class Program
{
    private static void Main(string[] args)
    {

        Console.Write("Enter a number: ");
        double x = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
        while (x >= 0.0)
        {
            double squareRoot = Math.Sqrt(x);
            Console.WriteLine("Square root: " + squareRoot.ToString("F3", CultureInfo.InvariantCulture));
            Console.Write("Enter another number: ");
            x = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

        }
        
        Console.WriteLine("Negative number!");

    }
}