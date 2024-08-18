public abstract class Transaction {
    protected BankAccount _account;

    protected Transaction(BankAccount account) {
        _account = account;
    }

    public abstract void Execute(decimal amount, Currency currency);
}

public class DepositTransaction : Transaction {
    public DepositTransaction(BankAccount account) : base(account) {}

    public override void Execute(decimal amount, Currency currency)
    {
        _account.Deposit(amount, currency);
    }
}

public class WithdrawTransaction : Transaction {
    public WithdrawTransaction(BankAccount account) : base(account) {}
    public override void Execute(decimal amount, Currency currency)
    {
        _account.Withdraw(amount, currency);
    }
}