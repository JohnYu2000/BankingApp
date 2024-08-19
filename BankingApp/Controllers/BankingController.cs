using Microsoft.AspNetCore.Mvc;

public class BankingController : Controller {
    private static BankAccount _account = new BankAccount(1000);

    public IActionResult Index() {
        return View(_account);
    }

    [HttpPost]
    public IActionResult ProcessTransaction(decimal amount, string currencyCode, string transactionType) {
        Currency? currency = CreateCurrency(currencyCode);
        if (currency == null) {
            ViewBag.ErrorMessage = "Invalid currency.";
            return View("Index", _account);
        }

        Transaction? transaction = CreateTransaction(transactionType);
        if (transaction == null) {
            ViewBag.ErrorMessage = "Invalid transaction type.";
            return View("Index", _account);
        }

        string result = transaction.Execute(amount, currency);

        if (result.StartsWith("Error")) {
            ViewBag.ErrorMessage = result;
        }

        // Return to the same index with updated model
        return View("Index", _account);
    }

    private Currency? CreateCurrency(string currencyCode) {
        switch (currencyCode) {
            case "USD":
                return new UsdCurrency();
            case "MXN":
                return new MxnCurrency();
            case "EURO":
                return new EuroCurrency();
            case "CAD":
                return new CadCurrency();
            default:
                return null;
        };
    }

    private Transaction? CreateTransaction(string transactionType) {
        switch (transactionType) {
            case "Deposit":
                return new DepositTransaction(_account);
            case "Withdraw":
                return new WithdrawTransaction(_account);
            default:
                return null;
        }
    }
}