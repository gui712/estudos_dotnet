internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Inference Types \n");

        var age = 25;
        var name = "Natalia";
        var salary = 5500.50;

        Console.WriteLine($"{name} is {age} years old and earns {salary}");
        Console.WriteLine($"The variable age is of type: {age.GetType()}");
        Console.WriteLine($"The variable name is of type: {name.GetType()}");
    }
}