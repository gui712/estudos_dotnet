Console.WriteLine("Switch instruction");

Console.Write("Enter the name of the month: ");
string month = Console.ReadLine().ToLower();

switch (month)
{
    case "january":
        Console.WriteLine("It's the first month of the year.");
        break;
    case "february":
        Console.WriteLine("It's the second month of the year.");
        break;
    case "march":
        Console.WriteLine("It's the third month of the year.");
        break;
    default:
        Console.WriteLine("Invalid month.");
        break;
}
