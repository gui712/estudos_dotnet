internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Structure for !");
        Console.Write("How much numbers your is digit? ");
        int n = Convert.ToInt32(Console.ReadLine());
        double result =0.0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter a number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            result += x;
        }
        Console.WriteLine("Sum of numbers: " + result);



    }
}