using Shared.ValueObjects;

namespace Shared.Tests.ValueObjects;

public class MoneyTests
{
    [Fact]
    public void MoneyToString_ReturnsFormattedText()
    {
        var money = new Money(100, Currency.Default);

        Assert.Equal("100 PLN", money.ToString());
    }
}