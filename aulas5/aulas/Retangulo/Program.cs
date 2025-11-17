using Retangulo;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, Retangulo!");

        Retangle retangle = new Retangle();
        Console.Write("Enter rectangle width: ");
        retangle.Width = double.Parse(Console.ReadLine());
        Console.Write("Enter rectangle height: ");
        retangle.Height = double.Parse(Console.ReadLine());
        Console.WriteLine(retangle);

    }
}