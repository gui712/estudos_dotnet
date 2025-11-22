
using System.Globalization;
namespace ContaBanco
{
    public class BankAccount
    {
        public int AccountNumber { get; private set; }
        public string AccountHolder { get; set; }
        public double Balance { get; private set; }

        public BankAccount(int accountNumber, string accountHolder)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = 0.0;
        }

        public BankAccount(int accountNumber, string accountHolder, double initialDeposit) : this(accountNumber, accountHolder)
        {
            Deposit(initialDeposit);
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            Balance -= amount + 5.0; // Assuming a withdrawal fee of 5.0
        }

        public override string ToString()
        {
            return "Account "
                + AccountNumber
                + ", Holder: "
                + AccountHolder
                + ", Balance: $ "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
        
    }
}