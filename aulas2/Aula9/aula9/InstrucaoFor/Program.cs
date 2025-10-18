Console.WriteLine("Istruction For in C#");

int result, number;

Console.WriteLine("Enter a number to see its multiplication table:");
number = Convert.ToInt32(Console.ReadLine());
for (int count = 0; count <= 10; count++)
{
    result = number * count;
    Console.WriteLine($"{number} x {count} = {result}");
}
Console.WriteLine("End of For Instruction");

