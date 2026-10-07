namespace Lab03.currencies;

public class CurrencyUSD : Currency
{
    public static double EurRate { get; set; } = 0.9;
    public static double RubRate { get; set; } = 100;

    public CurrencyUSD(double value) => Value = value;

    public static implicit operator CurrencyEUR(CurrencyUSD v) => new CurrencyEUR(v.Value * EurRate);
    public static implicit operator CurrencyRUB(CurrencyUSD v) => new CurrencyRUB(v.Value * RubRate);
}