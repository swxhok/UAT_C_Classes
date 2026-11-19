namespace UAT_C_First_Class;

// ==========================================
// CHALLENGE 2: SAVINGS ACCOUNT CLASS
// ==========================================
// Represents a single savings account held by a customer.
// A Customer can hold multiple SavingsAccount objects using a List<SavingsAccount>.
public class SavingsAccount
{
    // Auto-implemented properties (decimal is used for currency precision)
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }

    // Constructor
    public SavingsAccount(string accountNumber, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    // Method to deposit money into this account
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    // Method returning a readable summary of the account
    public string GetSummary()
    {
        return $"Account {AccountNumber}: £{Balance:N2}";
    }
}

