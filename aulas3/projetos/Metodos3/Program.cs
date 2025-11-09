// See https://aka.ms/new-console-template for more information
Console.WriteLine("Methods with Parameters and Return Values");

Student student = new Student();
student.GetStudentInfo();


public class Student
{
    public string? Name;
    public int Age;
    public string? Gender;
    public string? Approved;

    public void GetStudentInfo()
    {
        Student student = new Student();

        Console.WriteLine("Enter the student's name:");
        student.Name = Console.ReadLine();
        Console.WriteLine("Enter the student's age:");
        student.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the student's gender:");
        student.Gender = Console.ReadLine();
        Console.WriteLine("Enter the student's approval status (Y/N):");
        student.Approved = Console.ReadLine();

        Course course = new Course();
        course.result(student);
    }
}

public class Course
{
    public void result(Student student)
    {
        Console.WriteLine($"The Student Name: {student.Name}, gender: {student.Gender}, age: {student.Age} years old, was {student.Approved} ");
        if (student.Approved == "Y")
        {
            Console.WriteLine("Congratulations!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
        
}