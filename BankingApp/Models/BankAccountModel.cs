public class BankAccount {
    public decimal Balance { get; private set; }

    public BankAccount(decimal initialBalance) {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount, Currency currency) {
        decimal cadAmount = currency.ConvertToCad(amount);
        Balance += cadAmount;
    }

    public void Withdraw(decimal amount, Currency currency) {
        decimal cadAmount = currency.ConvertToCad(amount);
        if (cadAmount <= Balance) {
            Balance -= cadAmount;
        } else {
            throw new InvalidOperationException("Insufficient funds.");
        }
    }
}
