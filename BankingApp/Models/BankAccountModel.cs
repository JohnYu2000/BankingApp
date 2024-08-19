public class BankAccount {
    public decimal Balance { get; private set; }

    public BankAccount(decimal initialBalance) {
        Balance = initialBalance;
    }

    public string Deposit(decimal amount, Currency currency) {
        decimal cadAmount = currency.ConvertToCad(amount);
        Balance += cadAmount;
        return "Deposit successful.";
    }

    public string Withdraw(decimal amount, Currency currency) {
        decimal cadAmount = currency.ConvertToCad(amount);
        if (cadAmount <= Balance) {
            Balance -= cadAmount;
            return "Withdrawal successful.";
        } else {
            return "Error: Insufficient funds.";
        }
    }
}
