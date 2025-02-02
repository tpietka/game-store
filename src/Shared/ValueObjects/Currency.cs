namespace Shared.ValueObjects;

public record Currency(Currencies Value)
{
    public static implicit operator Currencies(Currency currency) => currency.Value;
    public static explicit operator Currency(Currencies value) => new Currency(value);

    public static Currency Default => new Currency(Currencies.PLN);
}