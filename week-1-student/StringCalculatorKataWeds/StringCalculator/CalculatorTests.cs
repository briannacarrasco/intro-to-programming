

namespace StringCalculator;
public class CalculatorTests
{
    // REQUIREMENT 1
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();
        var result = calculator.Add("");
        Assert.Equal(0, result);
    }

    // REQUIREMENT 2
    [Theory]
    [InlineData("3",3)]
    [InlineData("4",4)]
    [InlineData("420",420)]
    public void CanAddASingleNumber(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    // REQUIREMENT 3 
    [Theory]
    [InlineData("2,2", 4)]
    public void CanAddStringWithTwoIntegers(string values, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(values);
        Assert.Equal(expected, result);
    }

    // REQUIREMENT 4
    [Theory]
    [InlineData("1,2",3)]
    [InlineData("1,2,3",6)]
    public void CanAddStringWithArbitaryLength(string values, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(values);
        Assert.Equal(expected, result);
    }
    // REQUIREMENT 5
    [Theory]
    [InlineData("2\n2", 4)]
    [InlineData("1\n2,3",6)]
    public void CanAddStringWithMixDelimiters(string values, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(values);
        Assert.Equal(expected, result);
    }
}
