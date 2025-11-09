internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("What time is it?");
        int time = Convert.ToInt32(Console.ReadLine());

        if (time < 12)
        {
            Console.WriteLine("Good morning!");
        }
        else if (time < 18)
        {
            Console.WriteLine("Good afternoon!");
        }
        else
        {
            Console.WriteLine("Good evening!");
        }
    }
}