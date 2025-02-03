namespace Shared.ValueObjects;

public record Money
{
    public decimal Amount { get; }
    public Currency Currency { get; }

    public Money(decimal amount, Currency currency)
    {
        if (currency is null)
        {
            throw new ArgumentException("Currency cannot be empty.", nameof(currency));
        }

        Amount = amount;
        Currency = currency;
    }

    public override string ToString() => $"{Amount} {Currency.Value}";


    public static implicit operator decimal(Money money) => money.Amount;
    public static explicit operator Money(decimal amount) => new Money(amount, Currency.Default);

}
