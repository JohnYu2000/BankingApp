// This class performs a transaction. It takes in an amount as well as a CurrencyConverter
// and performs a withdraw or deposit to the users bank account.
public abstract class Transaction {
    protected BankAccount _account;

    protected Transaction(BankAccount account) {
        _account = account;
    }

    // This method executes a transaction to withdraw or deposit money to the user's bank account
    // Parameters:
    //  - amount: the amount to deposit or withdaw
    //  - currencyConverter: a CurrencyConverter to convert the amount to Canadian dollars
    // Returns:
    //  - string: the result of execution which will be used to catch any errors during the transaction
    public abstract string Execute(decimal amount, CurrencyConverter currencyConverter);
}

public class DepositTransaction : Transaction {
    public DepositTransaction(BankAccount account) : base(account) {}

    public override string Execute(decimal amount, CurrencyConverter currencyConverter)
    {
        return _account.Deposit(amount, currencyConverter);
    }
}

public class WithdrawTransaction : Transaction {
    public WithdrawTransaction(BankAccount account) : base(account) {}
    public override string Execute(decimal amount, CurrencyConverter currencyConverter)
    {
        return _account.Withdraw(amount, currencyConverter);
    }
}