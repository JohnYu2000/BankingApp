using Microsoft.AspNetCore.Mvc;

public class BankingController : Controller {
    private static BankAccount _account = new BankAccount(1000);

    public IActionResult Index() {
        return View(_account);
    }

    [HttpPost]
    public IActionResult Deposit(double amount, string currency) {
        _account.Deposit(amount, currency);
        return RedirectToAction("Index");
    }

    [HttpPost]
    public IActionResult Withdraw(double amount, string currency) {
        try {
            _account.Withdraw(amount, currency);
        } catch (InvalidOperationException ex) {
            ViewBag.ErrorMessage = ex.Message;
        }
        return RedirectToAction("Index");
    }
}