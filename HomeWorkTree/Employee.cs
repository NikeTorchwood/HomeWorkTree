namespace HomeWorkTree;

public class Employee
{
    public Employee(string name, int salary)
    {
        Name = name;
        Salary = salary;
    }

    public string Name { get; set; }
    public int Salary { get; set; }
    public Employee LeftEmployee { get; set; }
    public Employee RightEmployee { get; set; }

    public void PrintEmployee()
    {
        Console.WriteLine($"Name = {Name} - Salary = {Salary}");
    }

    public void PrintSalary()
    {
        Console.WriteLine($"Employee = {Name}");
    }
}