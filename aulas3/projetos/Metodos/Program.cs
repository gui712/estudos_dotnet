Console.WriteLine("Methods Project  - C#");

MyClass myClass = new MyClass();
myClass.sayHello();
myClass.showDate();
myClass.sayGoodbye();

class MyClass
{
    public void sayHello()
    {
        Console.WriteLine("Hello from MyClass!");
    }

    public void showDate()
    {
        Console.WriteLine(DateTime.Now);
    }

    public void sayGoodbye()
    {
        Console.WriteLine("Goodbye from MyClass!");
    }
}