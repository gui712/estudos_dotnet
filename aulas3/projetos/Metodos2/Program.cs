
using System.Runtime.CompilerServices;

Console.WriteLine("Methods with Parameters");

MyClass myClass = new MyClass();
myClass.DisplayMessage("Valeria", DateTime.Now);

public class MyClass
{
    public void DisplayMessage(string name, DateTime date)
    {
        Console.WriteLine($"Hello, {name}! Today's date is {date.ToShortDateString()}.");
    }
}