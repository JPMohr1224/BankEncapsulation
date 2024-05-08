namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var userBankAccount = new BankAccount(0);
            userBankAccount.GetBalance();
            Console.WriteLine("Would you like to make a deposit?");
            userBankAccount.Deposit(2500);
            userBankAccount.GetBalance();
        }
    }
}
