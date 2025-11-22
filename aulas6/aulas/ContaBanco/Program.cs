using System.Globalization;
using ContaBanco;
internal class Program
{
    private static void Main(string[] args)
    {
        BankAccount account;
        Console.WriteLine("Enter account number:");
        int accountNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter account holder:");
        string accountHolder = Console.ReadLine();
        Console.WriteLine("Is there an initial deposit (y/n)?");
        char hasInitialDeposit = char.Parse(Console.ReadLine());
        if(hasInitialDeposit == 'y' || hasInitialDeposit == 'Y')
        {
            Console.WriteLine("Enter initial deposit value:");
            double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account = new BankAccount(accountNumber, accountHolder, initialDeposit);
            Console.WriteLine("Account data:");
            Console.WriteLine(account);
            Console.WriteLine();
            Console.WriteLine("Enter a deposit value:");
            double depositValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(depositValue);
            Console.WriteLine("Updated account data:");
            Console.WriteLine(account);
            Console.WriteLine();
            Console.WriteLine("Enter a withdraw value:");
            double withdrawValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(withdrawValue);
            Console.WriteLine("Updated account data:");
            Console.WriteLine(account);
        }
        else
        {
            account = new BankAccount(accountNumber, accountHolder);
            Console.WriteLine("Account data:");
            Console.WriteLine(account);
            Console.WriteLine();
            Console.WriteLine("Enter a deposit value:");
            double depositValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(depositValue);
            Console.WriteLine("Updated account data:");
            Console.WriteLine(account);
            Console.WriteLine();
            Console.WriteLine("Enter a withdraw value:");
            double withdrawValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdraw(withdrawValue);
            Console.WriteLine("Updated account data:");
            Console.WriteLine(account);
        }
    }
}