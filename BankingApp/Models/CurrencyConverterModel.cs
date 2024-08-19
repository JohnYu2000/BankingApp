// This class converts currencies. It takes in an amount and converts that
// amount to another currency.
public abstract class CurrencyConverter {
    // This method converts the amount to Canadian dollars (CAD).
    // Parameters:
    //  - amount: the amount to convert
    // Returns:
    //  - decimal: the money amount in Canadian dollars
    public abstract decimal ConvertToCad(decimal amount);
}

public class UsdCurrencyConverter : CurrencyConverter {
    public override decimal ConvertToCad(decimal amount) {
        return amount / 0.50m;  // USD to CAD conversion
    }
}

public class MxnCurrencyConverter : CurrencyConverter {
    public override decimal ConvertToCad(decimal amount) {
        return amount / 10.00m;  // MXN to CAD conversion
    }
}

public class EuroCurrencyConverter : CurrencyConverter {
    public override decimal ConvertToCad(decimal amount) {
        return amount / 0.25m;  // EURO to CAD conversion
    }
}

public class CadCurrencyConverter : CurrencyConverter {
    public override decimal ConvertToCad(decimal amount)
    {
        return amount;  // CAD to CAD conversion
    }
}