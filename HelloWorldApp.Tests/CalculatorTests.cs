using Xunit;
using HelloWorldApp;
using System.Reflection;

public class CalculatorTests
{
    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        // Arrange
        var calculator = new Calculator();

        // Act
        int result = calculator.Add(15, 20);

        //Assert
        Assert.Equal(35, result);
    }

    [Fact]
    public void Subtract_ReturnsCorrectDifference()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        int result = calculator.Subtract(20, 45);

        //Assert
        Assert.Equal(-25, result);
    }
}