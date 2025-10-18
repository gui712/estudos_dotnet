// See https://aka.ms/new-console-template for more information
Console.WriteLine("If-Else instructions in C#   \n");

Console.WriteLine("Enter the student's grade: \t");
int grade = Convert.ToInt32(Console.ReadLine());

if (grade >= 6)
{
    Console.WriteLine("Student approved.");
}
else
{
    Console.WriteLine("Student disapproved.");
}

Console.WriteLine("\nEnd of program.");
Console.ReadKey();
