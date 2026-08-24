namespace Opgave03;

public class BankAccount
{
    public string AccountNumber { get; init; }
    
    
    public decimal Balance { get; private set; }
    public bool IsOverdrawn => Balance > 0;
    
    
    public BankAccount(string accountNumber, decimal balance)
    {}
}
