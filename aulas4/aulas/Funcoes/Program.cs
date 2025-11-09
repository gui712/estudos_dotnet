using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a three numbers:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        int n3 = Convert.ToInt32(Console.ReadLine());

        double result = BiggerNumber(n1, n2, n3);
        Console.WriteLine("The bigger number is: " + result);

    }
    static int BiggerNumber(int n1, int n2, int n3)
    {
        int bigger;
        if (n1 > n2 && n1 > n3)
        {
            bigger = n1;
        }
        else if (n2 > n3)
        {
            bigger = n2;
        }
        else
        {
            bigger = n3;
        }
        return bigger;
    }
}