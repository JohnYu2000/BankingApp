// This class converts currencies. It takes in an amount and converts that
// amount to another currency.
public abstract class CurrencyConverter {
    // This method converts the amount to Canadian dollars (CAD).
    // Parameters:
    //  - amount: the amount to convert
    // Returns:
    //  - decimal: the amount in Canadian dollars
    public abstract decimal ConvertToCad(decimal amount);
}

// This class converts USD to CAD.
public class UsdCurrencyConverter : CurrencyConverter {
    // This method converts USD to CAD
    // Parameters:
    //  - amount: the amount in USD
    // Returns:
    //  - decimal: the amount in CAD
    public override decimal ConvertToCad(decimal amount) {
        return amount / 0.50m;  // USD to CAD conversion
    }
}

// This class converts MXN to CAD
public class MxnCurrencyConverter : CurrencyConverter {
    // This method converts MXN to CAD
    // Parameters:
    //  - amount: the amount in MXN
    // Returns:
    //  - decimal: the amount in CAD
    public override decimal ConvertToCad(decimal amount) {
        return amount / 10.00m;  // MXN to CAD conversion
    }
}

// This class converts Euro to CAD
public class EuroCurrencyConverter : CurrencyConverter {
    // This method converts EURO to CAD
    // Parameters:
    //  - amount: the amount in EURO
    // Returns:
    //  - decimal: the amount in CAD
    public override decimal ConvertToCad(decimal amount) {
        return amount / 0.25m;  // EURO to CAD conversion
    }
}

// This class converts CAD to CAD
public class CadCurrencyConverter : CurrencyConverter {
    // This method converts CAD to CAD
    // Parameters:
    //  - amount: the amount in CAD
    // Returns:
    //  - decimal: the amount in CAD
    public override decimal ConvertToCad(decimal amount)
    {
        return amount;  // CAD to CAD conversion
    }
}