using Vetores3;

Student[] rooms = new Student[10];
Console.WriteLine("How many rooms will be rented?");
int n = int.Parse(Console.ReadLine());
for(int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter the name of student {i}:");
    string name = Console.ReadLine();
    Console.WriteLine($"Enter the email of student {i}:");
    string email = Console.ReadLine();
    Console.WriteLine($"Enter the room number (0 to 9) for student {i}:");
    int room = int.Parse(Console.ReadLine());
    rooms[room] = new Student(name, email);
}
Console.WriteLine("Busy rooms:");
for(int i = 0; i < 10; i++)
{
    if(rooms[i] != null)
    {
        Console.WriteLine($"{i}: {rooms[i].Name}, {rooms[i].Email}");
    }
}