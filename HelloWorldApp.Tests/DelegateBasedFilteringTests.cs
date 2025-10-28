using System.Diagnostics.Tracing;
using System.Globalization;
using System.Reflection;
using Microsoft.VisualBasic;

public class DelegateBasedFilteringTests
{
    [Fact]

    public void EvensFiltering_ReturnCorrect()
    {
        //Arrange
        var delegateBasedFilteringDemo = new DelegateBasedFiltering();
        var nums = new List<int> { 3, 7, 9, 10, 12, 20 };

        //Act
        var evens = delegateBasedFilteringDemo.FilterList(nums, n => n % 2 == 0);

        //Assertion
        Assert.Contains(evens, n => n % 2 == 0);
        Assert.All(evens, n => Assert.True(n % 2 == 0));
    }
}