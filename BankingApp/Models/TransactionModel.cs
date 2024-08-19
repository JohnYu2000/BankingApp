public abstract class Transaction {
    protected BankAccount _account;

    protected Transaction(BankAccount account) {
        _account = account;
    }

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