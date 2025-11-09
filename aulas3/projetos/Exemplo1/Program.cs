Console.WriteLine("Exemple 1 Methods");

Register register = new Register();
Consumer consumer1 = register.registerConsumer();
register.showConsumer(consumer1);

consumer1 = register.registerConsumer(consumer1);
register.showConsumer(consumer1);


public class Consumer
{
    public string? name;
    public int age;
    public decimal salary;

    public Consumer(string name, int age, decimal salary)
    {
        this.name = name;
        this.age = age;
        this.salary = salary;
    }

    public Consumer()
    {

    }
}

public class Register
{
    public Consumer registerConsumer()
    {
        Consumer consumer = new Consumer("Váleria", 30, 6000);
        return consumer;
    }

    public Consumer registerConsumer(Consumer consumer)
    {
        consumer.salary = 8000;
        return consumer;
    }

    public void showConsumer(Consumer consumer)
    {
        Console.WriteLine("Name: " + consumer.name);
        Console.WriteLine("Age: " + consumer.age);
        Console.WriteLine("Salary: " + consumer.salary);
    }
}
