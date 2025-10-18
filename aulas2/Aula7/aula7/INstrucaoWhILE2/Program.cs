// See https://aka.ms/new-console-template for more information
Console.WriteLine("While instruction");

while (true)
{
    Console.WriteLine("\n Enter a integer number (0 to exit): ");
    int number = Convert.ToInt32(Console.ReadLine());

    if (number == 0)
    {
        break;
    }

    if (number % 2 == 0)
    {
        Console.WriteLine($"The number {number} is even");
    }
    else
    {
        Console.WriteLine($"The number {number} is odd");
    }
        

}

Console.WriteLine("End of program");