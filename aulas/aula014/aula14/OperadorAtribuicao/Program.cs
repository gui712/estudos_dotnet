// See https://aka.ms/new-console-template for more information
Console.WriteLine("Atribuition Operators!");

var x = 10;
var y = 5;

Console.WriteLine($"Initial values: x = {x}, y = {y}");

x += y;
Console.WriteLine($"After x += y: x = {x}");

x -= y;
Console.WriteLine($"After x -= y: x = {x}");

x *= y;
Console.WriteLine($"After x *= y: x = {x}");

x /= y;
Console.WriteLine($"After x /= y: x = {x}");

x %= y;
Console.WriteLine($"After x %= y: x = {x}");
