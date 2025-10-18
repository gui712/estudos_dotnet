// See https://aka.ms/new-console-template for more information
Console.WriteLine("While instruction");

int i = 1;
while (i <= 10)
{
    Console.WriteLine(i);
    i++;
}

Console.WriteLine("End of the program.");

int number;
int count = 1;
Console.Write("\nEnter a number to calculate its multiplication table: ");
number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    while (count <= 10)
    {
        Console.WriteLine($"{number} x {count} = {number * count}");
        count++;
    }

}
else
{
    Console.WriteLine("Please enter a positive number.");
}
