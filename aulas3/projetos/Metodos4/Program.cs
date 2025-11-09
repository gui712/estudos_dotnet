Console.WriteLine("Methods with Return Types");

Calculator calc = new Calculator();
int result = calc.sum(5, 10);
Console.WriteLine("The sum is: " + result);

result = calc.subtract(5, 10);
Console.WriteLine("The subtraction is: " + result);

result = calc.multiply(5, 10);
Console.WriteLine("The multiplication is: " + result);

result = calc.divide(5, 10);
Console.WriteLine("The division is: " + result);

Console.ReadKey();

public class Calculator
{
    public int sum(int n1, int n2)
    {
        return n1 + n2;
    }

    public int subtract(int n1, int n2)
    {
        return n1 - n2;
    }

    public int multiply(int n1, int n2)
    {
        return n1 * n2;
    }

    public int divide(int n1, int n2)
    {
        return n1 / n2;
    }
}