public abstract class CurrencyConverter {
    public abstract decimal ConvertToCad(decimal amount);
}

public class UsdCurrencyConverter : CurrencyConverter {
    public UsdCurrencyConverter() {}

    public override decimal ConvertToCad(decimal amount) {
        return amount / 0.50m;  // USD to CAD conversion
    }
}

public class MxnCurrencyConverter : CurrencyConverter {
    public MxnCurrencyConverter() {}

    public override decimal ConvertToCad(decimal amount) {
        return amount / 10.00m;  // MXN to CAD conversion
    }
}

public class EuroCurrencyConverter : CurrencyConverter {
    public EuroCurrencyConverter() {}

    public override decimal ConvertToCad(decimal amount) {
        return amount / 0.25m;  // EURO to CAD conversion
    }
}

public class CadCurrencyConverter : CurrencyConverter {
    public CadCurrencyConverter() {}

    public override decimal ConvertToCad(decimal amount)
    {
        return amount;  // CAD to CAD conversion
    }
}