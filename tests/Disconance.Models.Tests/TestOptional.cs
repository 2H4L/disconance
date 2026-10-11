namespace Disconance.Models.Tests;

public class TestOptional
{
    [Fact]
    public void HasValue_DefaultOptional_ReturnsFalse()
    {
        Optional<string?> sut = default;

        var result = sut.HasValue;

        Assert.False(result);
    }

    [Fact]
    public void Value_Absent_ThrowsInvalidOperationException()
    {
        Optional<string?> sut = default;

        Assert.Throws<InvalidOperationException>(() => sut.Value);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("hello")]
    public void Constructor_SuppliedValue_CreatesPresentOptional(string? value)
    {
        var sut = new Optional<string?>(value);

        Assert.True(sut.HasValue);
        Assert.Equal(value, sut.Value);
    }

    [Fact]
    public void ImplicitConversion_Zero_CreatesPresentOptional()
    {
        Optional<int> sut = 0;

        Assert.True(sut.HasValue);
        Assert.Equal(0, sut.Value);
    }

    [Fact]
    public void ImplicitConversion_False_CreatesPresentOptional()
    {
        Optional<bool> sut = false;

        Assert.True(sut.HasValue);
        Assert.False(sut.Value);
    }

    [Fact]
    public void GetValueOrDefault_Absent_ReturnsFallback()
    {
        Optional<string?> sut = default;

        var result = sut.GetValueOrDefault("fallback");

        Assert.Equal("fallback", result);
    }

    [Theory]
    [InlineData(null)]
    [InlineData("hello")]
    public void GetValueOrDefault_Present_ReturnsSuppliedValue(string? value)
    {
        var sut = new Optional<string?>(value);

        var result = sut.GetValueOrDefault("fallback");

        Assert.Equal(value, result);
    }
}