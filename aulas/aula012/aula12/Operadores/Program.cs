Console.WriteLine("##Operators Arithmetic## \n");

Console.WriteLine("Enter the x value: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the y value: ");
int y = Convert.ToInt32(Console.ReadLine());
/*
int sum = x + y;
int sub = x - y;
int mult = x * y;
double div = (double) x / y;
int mod = x % y;

Console.WriteLine($"The sum x + y is: {sum}");
Console.WriteLine($"The sub x - y is: {sub}");
Console.WriteLine($"The mult x * y is: {mult}");
Console.WriteLine($"The div x / y is: {div}");
Console.WriteLine($"The mod x % y is: {mod}");
*/

Console.WriteLine($"\nThe square of x is {Math.Sqrt(x)}");
Console.WriteLine($"The pow of x^y is {Math.Pow(x, y)}");
Console.WriteLine($"The abs of x is {Math.Abs(x)}");
Console.WriteLine($"The round of x is {Math.Round((double)x)}");
Console.WriteLine($"The ceil of x is {Math.Ceiling((double)x)}");
Console.WriteLine($"The floor of x is {Math.Floor((double)x)}");
Console.WriteLine($"The max between x and y is {Math.Max(x, y)}");
Console.WriteLine($"The min between x and y is {Math.Min(x, y)}");
Console.WriteLine($"cos of x is {Math.Cos(x)}");
Console.WriteLine($"sin of x is {Math.Sin(x)}");