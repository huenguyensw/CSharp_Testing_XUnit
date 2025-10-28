using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using Hue2;

public class Ex1Tests
{
    [Fact]

    public void Find_ReturnCorrectResult()
    {
        //Arrange
        var repo = new Repository<Person>();
        repo.Add(new Person { Name = "John", Age = 23 });
        repo.Add(new Person { Name = "Alex", Age = 12 });
        repo.Add(new Person { Name = "Mia", Age = 40 });

        // Act
        var adults = repo.Find(p => p.Age >= 18);

        //Assertion
        Assert.Equal(2, adults.Count);
        Assert.Contains(adults, p => p.Name == "John");
        Assert.Contains(adults, p => p.Name == "Mia");
        Assert.DoesNotContain(adults, p => p.Name == "Alex");
        
    }
}