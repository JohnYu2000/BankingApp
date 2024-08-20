// This is a generic base class to perform a transaction on a user's bank account.
public abstract class Transaction {
    protected BankAccount _account;

    protected Transaction(BankAccount account) {
        _account = account;
    }

    // This method performs a transaction on the user's bank account
    // Parameters:
    //  - amount: the unconverted amount to deposit or withdaw
    //  - currencyConverter: converts the amount to Canadian dollars
    // Returns:
    //  - string: the result of execution used for error handling
    public abstract string Execute(decimal amount, CurrencyConverter currencyConverter);
}

// This class performs a deposit on the user's bank account.
public class DepositTransaction : Transaction {
    public DepositTransaction(BankAccount account) : base(account) {}

    // This method deposits money to a user's bank account
    // Parameters:
    //  - amount: the unconverted amount to deposit
    //  - currencyConverter: converts the amount to Canadian dollars
    // Returns:
    //  - string: the result of execution used for error handling
    public override string Execute(decimal amount, CurrencyConverter currencyConverter)
    {
        return _account.Deposit(amount, currencyConverter);
    }
}

// This class performs a withdrawal on the user's bank account.
public class WithdrawTransaction : Transaction {
    public WithdrawTransaction(BankAccount account) : base(account) {}
    
    // This method withdraws money from a user's bank account
    // Parameters:
    //  - amount: the unconverted amount to withdraw
    //  - currencyConverter: converts the amount to Canadian dollars
    // Returns:
    //  - string: the result of execution used for error handling
    public override string Execute(decimal amount, CurrencyConverter currencyConverter)
    {
        return _account.Withdraw(amount, currencyConverter);
    }
}