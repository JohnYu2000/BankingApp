public abstract class Currency {
    public abstract decimal ConvertToCad(decimal amount);
    public string CurrencyCode { get; protected set; }
}

public class UsdCurrency : Currency {
    public UsdCurrency() {
        CurrencyCode = "USD";
    }

    public override decimal ConvertToCad(decimal amount) {
        return amount / 0.50m;  // USD to CAD conversion
    }
}

public class MxnCurrency : Currency {
    public MxnCurrency() {
        CurrencyCode = "MXN";
    }

    public override decimal ConvertToCad(decimal amount) {
        return amount / 10.00m;  // MXN to CAD conversion
    }
}

public class EuroCurrency : Currency {
    public EuroCurrency() {
        CurrencyCode = "EURO";
    }

    public override decimal ConvertToCad(decimal amount) {
        return amount / 0.25m;  // EURO to CAD conversion
    }
}

public class CadCurrency : Currency {
    public CadCurrency() {
        CurrencyCode = "CAD";
    }

    public override decimal ConvertToCad(decimal amount)
    {
        return amount;  // CAD to CAD conversion
    }
}