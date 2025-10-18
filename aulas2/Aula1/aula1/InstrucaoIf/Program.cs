Console.WriteLine("If instructions in C#");

Console.WriteLine("Especial Client (Y/N)?");
string answer = Console.ReadLine();

if (answer == "Y")
{
    Console.WriteLine("10% discount on the product");
}

Console.WriteLine("Enter the x value:");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the y value:");
int y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    Console.WriteLine("X is greater than Y");
}
if (x < y)
{
    Console.WriteLine("X is less than Y");
}
if (x == y)
{
    Console.WriteLine("X is equal to Y");
}


Console.WriteLine("Press any key to exit...");
Console.ReadKey();
