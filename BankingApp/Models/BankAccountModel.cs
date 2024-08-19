// This class is the model to represent a BankAccount. It stores a balance of the user and
// allows withdraws and deposits.
public class BankAccount {
    public decimal Balance { get; private set; }

    public BankAccount(decimal initialBalance) {
        Balance = initialBalance;
    }

    // This method deposits funds from the user's bank account
    // Parameters:
    //  - amount: the amount (unconverted) to deposit
    //  - currencyConverter: converts the amount to Canadian dollars
    // Returns:
    //  - string: the result of the deposit which will be used for error handling
    public string Deposit(decimal amount, CurrencyConverter currencyConverter) {
        decimal cadAmount = currencyConverter.ConvertToCad(amount);
        Balance += cadAmount;
        return "Deposit successful.";
    }

    // This method withdraws funds from the user's bank account
    // Parameters:
    //  - amount: the amount (unconverted) to withdraw
    //  - currencyConverter: converts the amount to Canadian dollars
    // Returns:
    //  - string: the result of the withdraw which will be used for error handling
    public string Withdraw(decimal amount, CurrencyConverter currencyConverter) {
        decimal cadAmount = currencyConverter.ConvertToCad(amount);
        if (cadAmount <= Balance) {  // Ensures the user cannot go into debt
            Balance -= cadAmount;
            return "Withdrawal successful.";
        }
        return "Error: Insufficient funds.";
    }
}