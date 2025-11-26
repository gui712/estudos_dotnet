using System.Globalization;
using Vetores2;

Console.WriteLine("Enter the number of products:");

int n = int.Parse(Console.ReadLine());

Product[] vect = new Product[n];

for(int i = 0; i < n; i++)
{
    Console.WriteLine("Enter the product name and price:");
    string name = Console.ReadLine();
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    vect[i] = new Product(name, price); 
    
} 

double sum = 0.0;

for(int i = 0; i < n; i++)
{
    sum += vect[i].Price;
}

double average = sum / n;
Console.WriteLine($"Average price: {average.ToString("F2", CultureInfo.InvariantCulture)}");
