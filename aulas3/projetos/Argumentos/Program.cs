Console.WriteLine("Args values:");

int x = 20;

Console.WriteLine("\n Arguments values before modification:" + x);

Calc calc = new Calc();
calc.DoubleValue(x);

Console.WriteLine($"\n Arguments values after method call: {x}");

Console.ReadKey();

public class Calc
{
    public void DoubleValue(int y)
    {
        y *= 2;
        Console.WriteLine($"\n Value inside method: {y}");
    }
}