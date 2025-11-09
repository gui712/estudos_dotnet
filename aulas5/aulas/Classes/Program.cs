using System;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        double xA, xB, xC, yA, yB, yC, areaX, areaY, p;
        Console.WriteLine("Entre com as medidas do triângulo x: ");
        xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        
        Console.WriteLine("Entre com as medidas do triângulo y: ");
        yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        p = (xA + xB + xC) / 2.0;
        areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

        p = (yA + yB + yC) / 2.0;
        areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

        Console.WriteLine("Área do triângulo X: " + areaX.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Área do triângulo Y: " + areaY.ToString("F2", CultureInfo.InvariantCulture));

        if (areaX > areaY)
        {
            Console.WriteLine("O triângulo X tem a maior área.");
        }
        else
        {
            Console.WriteLine("O triângulo Y tem a maior área.");
        }
    }
}