// See https://aka.ms/new-console-template for more information
Console.WriteLine("Constructor Example!");

public class Student
{
    public Student(string name)
    {
        Name = name;
    }

    public Student(string name, int age, string gender, string approved)
    {
        Name = name;
        Age = age;
        Gender = gender;
        Approved = approved;
    }
    
    public string? Name;
    public int Age;
    public string? Gender;
    public string? Approved;

}
