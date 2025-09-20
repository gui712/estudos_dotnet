internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Constants in C# ");

        const int YEAR = 12;

        const int MONTHS = 30, WEEKS = 7;

        const int MONTHS_IN_YEAR = 12;
        const int DAYS_IN_YEAR = 365;

        double radius, area, perimeter;
        const double PI = 3.14;

        Console.Write("Enter the radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());

        area = PI * radius * radius;
        perimeter = 2 * PI * radius;

        Console.WriteLine("Area: " + area);
        Console.WriteLine("Perimeter: " + perimeter);
    }
}