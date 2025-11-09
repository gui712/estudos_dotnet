Console.WriteLine("Methods showing Overloading");

Email email = new Email();
email.send("example@example.com");
email.send("example@example.com", "Hello");
email.send("example@example.com", "Hello", "This is a test email.");

Console.ReadKey();

public class Email
{
    public void send(string to)
    {
        Console.WriteLine("Sending email to: " + to);
    }

    public void send(string to, string subject)
    {
        Console.WriteLine("Sending email to: " + to + " with subject: " + subject);
    }

    public void send(string to, string subject, string body)
    {
        Console.WriteLine("Sending email to: " + to + " with subject: " + subject + " and body: " + body);
    }
}