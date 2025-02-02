namespace Shared.ValueObjects;

public record Money(decimal Value, Currency Currency)
{
    public static implicit operator decimal(Money money) => money.Value;
    public static explicit operator Money(decimal value) => new Money(value, Currency.Default);

}
