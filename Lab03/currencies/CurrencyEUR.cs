namespace Lab03.currencies;

public class CurrencyEUR : Currency
{
    public static double RubRate => CurrencyUSD.RubRate / CurrencyUSD.EurRate;

    public CurrencyEUR(double value) => Value = value;

    public static implicit operator CurrencyUSD(CurrencyEUR v) => new CurrencyUSD(v.Value / CurrencyUSD.EurRate);
    public static implicit operator CurrencyRUB(CurrencyEUR v) => new CurrencyRUB(v.Value * RubRate);
}