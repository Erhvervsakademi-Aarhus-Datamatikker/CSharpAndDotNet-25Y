namespace Opgave03;

public class BankAccount
{
    public string AccountNumber { get; init; }

    private string _owner;

    public string Owner
    {
        get => _owner;
        set
        {
            if (string.IsNullOrEmpty(value))
                throw new ArgumentException("Owner name cannot be empty");
            _owner = value;
        }
    }
    
    
    public decimal Balance { get; private set; }

    public bool IsOverdrawn => Balance < 0;
    
    public string FormattedBalance => Balance.ToString("N2") + " DKK";

    public void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        Balance -= amount;
    }
    
}