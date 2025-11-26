using System.Globalization;

Console.WriteLine("Enter the number of elements:");
int n = int.Parse(Console.ReadLine());

double[] numbers = new double[n];

for(int i= 0; i < n; i++)
{
    Console.WriteLine($"Enter height {i + 1}:");
    numbers[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    
}

double sum = 0.0;
for(int i = 0; i < n; i++)
{
    sum += numbers[i];
}

double average = sum / n;
Console.WriteLine($"The average height is: {average.ToString("F2", CultureInfo.InvariantCulture)}");