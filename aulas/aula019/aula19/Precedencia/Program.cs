// See https://aka.ms/new-console-template for more information
using System.Data;

Console.WriteLine("Precedence and Associativity in C# ");

int x = 10 - 2 * 3;
Console.WriteLine(x);

bool b = !(2 + 2 != 4) && 10 > 5;
Console.WriteLine(b);

int r = 5, s = 6, t = 4;

int c = --r * s - ++t;

Console.WriteLine(c);

Console.ReadKey();