using System.Reflection;

public class EmployManagementSystemTests
{
    [Fact]
    public void GetAll_ReturnCorrect()
    {
        //Arrange
        var employRepo = new EmployeeRepository<Employee>();
        employRepo.Add(new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 35000 });
        employRepo.Add(new Employee { Id = 2, Name = "Mary", Department = "IT", Salary = 45000 });
        employRepo.Add(new Employee { Id = 3, Name = "Alex", Department = "R&D", Salary = 48000 });
        employRepo.Add(new Employee { Id = 4, Name = "Jone", Department = "R&D", Salary = 38000 });
        employRepo.Add(new Employee { Id = 5, Name = "Doe", Department = "HR", Salary = 28000 });
        employRepo.Add(new Employee { Id = 6, Name = "Alexande", Department = "Sale", Salary = 18000 });

        //Act
        var employees = employRepo.GetAll();

        //Assert
        Assert.Equal(6, employees.Count);
    }
    
    
    [Fact]
     public void EmployeesStartWithA_ReturnCorrect()
    {
        //Arrange
        var employRepo = new EmployeeRepository<Employee>();
        employRepo.Add(new Employee { Id = 1, Name = "Alice", Department = "HR", Salary = 35000 });
        employRepo.Add(new Employee { Id = 2, Name = "Mary", Department = "IT", Salary = 45000 });
        employRepo.Add(new Employee { Id = 3, Name = "Alex", Department = "R&D", Salary = 48000 });
        employRepo.Add(new Employee { Id = 4, Name = "Jone", Department = "R&D", Salary = 38000 });
        employRepo.Add(new Employee { Id = 5, Name = "Doe", Department = "HR", Salary = 28000 });
        employRepo.Add(new Employee { Id = 6, Name = "Alexande", Department = "Sale", Salary = 18000 });

        //Act
        var employees = employRepo.GetValues(e => e.Name.StartsWith("A"));

        //Assert
        Assert.Contains(employees, e => e.Name == "Alice");
        Assert.Contains(employees, e => e.Name == "Alex");
        Assert.Contains(employees, e => e.Name == "Alexande");
        Assert.Equal(3, employees.Count);


    }
}