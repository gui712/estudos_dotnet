Console.WriteLine("Instruction If...Else If");
Console.Write("Enter your grade:\t");

double grade = Convert.ToDouble(Console.ReadLine());

if (grade < 5)
{
    Console.WriteLine("\nYou failed!");
}
else if (grade >= 5 && grade < 6)
{
    Console.WriteLine("\nYou are in recovery.");
}
else if (grade >= 6 && grade <= 10)
{
    Console.WriteLine("\nYou passed!");
}
else
{
    Console.WriteLine("\nInvalid grade.");
}

Console.WriteLine("\nEnd of program.");
Console.ReadKey();