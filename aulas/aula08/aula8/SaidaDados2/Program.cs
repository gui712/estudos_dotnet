using System.Runtime.CompilerServices;

Console.WriteLine("Output data in C#: Using escape to format the output");
Console.WriteLine("\nThis is a line break:\nAnd this is the second line.");
Console.WriteLine("This is a tab:\tAnd this is after the tab.");
Console.WriteLine("This is a backslash: \\");
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++\n");

string local = "c:\\aula08\\saidaDados2.txt";
string phrase = "He says: \"it wasn't me.\"";

string pizza = "\nMozzarella\nPizza";
string cake = "\nChocolate\tCake";

Console.WriteLine($"File path: {local}");
Console.WriteLine($"Phrase with quotes: {phrase}");
Console.WriteLine($"Pizza: {pizza}");
Console.WriteLine($"Cake: {cake}");