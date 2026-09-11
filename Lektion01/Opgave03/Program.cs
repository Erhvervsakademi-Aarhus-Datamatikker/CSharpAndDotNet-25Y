namespace Opgave03;

class Program
{
    static void Main(string[] args)
    {
        var konto = new BankAccount { AccountNumber = "123", Owner = "Jinx" };
        konto.Deposit(5000);
        Console.WriteLine(konto.FormattedBalance);
    }
}