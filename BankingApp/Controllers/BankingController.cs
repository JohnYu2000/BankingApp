using Microsoft.AspNetCore.Mvc;

// This class is the main controller and executes processes according to the user's input.
public class BankingController : Controller {
    private static BankAccount _account = new BankAccount(1000);

    public IActionResult Index() {
        return View(_account);
    }

    // This method retrieves input from the View and processes the transaction.
    // Parameters:
    //  - amount: the amount to withdraw or deposit
    //  - currencyCode: the currency of the amount to deposit or withdraw
    //  - transactionType: the type of transaction to execute (e.g., withdraw, deposit)
    [HttpPost]
    public IActionResult ProcessTransaction(decimal amount, string currencyCode, string transactionType) {
        CurrencyConverter? currency = CreateCurrency(currencyCode);
        if (currency == null) {
            ViewBag.ErrorMessage = "Invalid currency.";
            return View("Index", _account);
        }

        Transaction? transaction = CreateTransaction(transactionType);
        if (transaction == null) {
            ViewBag.ErrorMessage = "Invalid transaction type.";
            return View("Index", _account);
        }

        string result = transaction.Execute(amount, currency);  // result of execution is used for error handling

        if (result.StartsWith("Error")) {  // if result message starts with "Error" it means transaction ran into an error
            ViewBag.ErrorMessage = result;
        }

        // Return to the same index with updated model
        return View("Index", _account);
    }

    // This method converts the currencyCode into its corresponding CurrencyConverter object
    // Parameters:
    //  - currencyCode: the currency the user is using
    // Returns:
    //  - CurrencyConverter: a CurrencyConverter object used for converting currencies to CAD
    private CurrencyConverter? CreateCurrency(string currencyCode) {
        switch (currencyCode) {
            case "USD":
                return new UsdCurrencyConverter();
            case "MXN":
                return new MxnCurrencyConverter();
            case "EURO":
                return new EuroCurrencyConverter();
            case "CAD":
                return new CadCurrencyConverter();
            default:
                return null;
        };
    }

    // This method converts the transactionType into its corresponding Transaction object
    // Parameters:
    //  - transactionType: the type of transaction to execute (i.e., withdraw, deposit)
    // Returns:
    //  - Transaction: a Transaction object used for executing a transaction
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