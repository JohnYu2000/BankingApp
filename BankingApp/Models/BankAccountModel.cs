// ExchangeRates is a static class instead of an ENUM because ENUMs cannot be doubles.
public static class ExchangeRates {
    public const double UsdToCad = 0.50;
    public const double MxnToCad = 10.00;
    public const double EuroToCad = 0.25;
}
public class BankAccount {
    public double Balance { get; private set; }

    public BankAccount(double initialBalance) {
        Balance = initialBalance;
    }

    public void Deposit(double amount, string currency) {
        double cadAmount = ConvertToCad(amount, currency);
        Balance += cadAmount;
    }

    public void Withdraw(double amount, string currency) {
        double cadAmount = ConvertToCad(amount, currency);
        if (cadAmount <= Balance) {
            Balance -= cadAmount;
        } else {
            throw new InvalidOperationException("Insufficient funds.");
        }
    }

    private double ConvertToCad(double amount, string currency) {
        return currency switch {
            "USD" => amount / ExchangeRates.UsdToCad,
            "MXN" => amount / ExchangeRates.MxnToCad,
            "EURO" => amount / ExchangeRates.EuroToCad,
            _ => amount,  // Assume CAD
        };
    }
}
