using System.ComponentModel.DataAnnotations;

Console.WriteLine("Output data in C# : Formation and Interpolation");

int age = 30;
string name = "Natalia";

Console.Write(name);
Console.WriteLine(age);
Console.WriteLine("************************");
// Concatenation
Console.WriteLine(name + " is " + age + " years old.");
Console.WriteLine("************************");
// interpolation string
Console.WriteLine($"{name} is {age} years old!");

//using placeholders
Console.WriteLine("************************");
Console.WriteLine("{0} is {1} years old!!", name, age);
Console.WriteLine("************************");