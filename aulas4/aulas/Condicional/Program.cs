internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int x = Convert.ToInt32(Console.ReadLine());
        if (x % 2 == 0)
        {
            Console.WriteLine("The number is even.");
        }
        else
        {
            Console.WriteLine("The number is odd.");
        }
    }
}