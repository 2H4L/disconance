using System.Globalization;

namespace Disconance.Models.Tests;

public class TestSnowflake
{
    [Theory]
    [InlineData("0", 0UL)]
    [InlineData("175928847299117063", 175928847299117063UL)]
    [InlineData("18446744073709551615", ulong.MaxValue)]
    public void Parse_UnsignedDecimal_PreservesValue(string text, ulong expected)
    {
        var result = Snowflake.Parse(text);

        Assert.Equal(expected, result.Value);
    }

    [Theory]
    [InlineData("0", 0UL)]
    [InlineData("175928847299117063", 175928847299117063UL)]
    [InlineData("18446744073709551615", ulong.MaxValue)]
    public void TryParse_UnsignedDecimal_ReturnsValue(string text, ulong expected)
    {
        var success = Snowflake.TryParse(text, out var result);

        Assert.True(success);
        Assert.Equal(expected, result.Value);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("-1")]
    [InlineData("+1")]
    [InlineData(" 1")]
    [InlineData("1 ")]
    [InlineData("1.0")]
    [InlineData("18446744073709551616")]
    public void TryParse_InvalidInput_ReturnsFalse(string? text)
    {
        var success = Snowflake.TryParse(text, out _);

        Assert.False(success);
    }

    [Theory]
    [InlineData(0UL, 1420070400000L)]
    [InlineData(175928847299117063UL, 1462015105796L)]
    public void Timestamp_EncodedIdentifier_ReturnsExpectedInstant(ulong value, long expectedMilliseconds)
    {
        var sut = new Snowflake(value);

        var result = sut.Timestamp;

        Assert.Equal(DateTimeOffset.FromUnixTimeMilliseconds(expectedMilliseconds), result);
    }

    [Theory]
    [InlineData(0UL, "0")]
    [InlineData(175928847299117063UL, "175928847299117063")]
    [InlineData(ulong.MaxValue, "18446744073709551615")]
    public void ToString_ArabicCulture_ReturnsInvariantDecimal(ulong value, string expected)
    {
        var previous = CultureInfo.CurrentCulture;

        try
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("ar-SA");
            var sut = new Snowflake(value);

            var result = sut.ToString();

            Assert.Equal(expected, result);
        }
        finally
        {
            CultureInfo.CurrentCulture = previous;
        }
    }

    [Theory]
    [InlineData(ulong.MaxValue, 1UL, 1)]
    [InlineData(1UL, ulong.MaxValue, -1)]
    [InlineData(42UL, 42UL, 0)]
    public void CompareTo_UnsignedValues_ReturnsNumericOrder(ulong value, ulong otherValue, int expectedSign)
    {
        var sut = new Snowflake(value);
        var other = new Snowflake(otherValue);

        var result = sut.CompareTo(other);

        Assert.Equal(expectedSign, Math.Sign(result));
    }
}