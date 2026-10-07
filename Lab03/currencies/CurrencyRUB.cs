namespace Lab03.currencies;

public class CurrencyRUB : Currency
{
    public CurrencyRUB(double value) => Value = value;

    public static implicit operator CurrencyUSD(CurrencyRUB v) => new CurrencyUSD(v.Value / CurrencyUSD.RubRate);
    public static implicit operator CurrencyEUR(CurrencyRUB v) => new CurrencyEUR(v.Value / CurrencyEUR.RubRate);
}