// See https://aka.ms/new-console-template for more information
Console.WriteLine("\nData Entry in C#");

Console.WriteLine("\nEnter your name: ");

string name = Console.ReadLine();

Console.WriteLine("\nEnter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Your name is {name}");
Console.WriteLine($"Your age is {age}");

Console.ReadKey();