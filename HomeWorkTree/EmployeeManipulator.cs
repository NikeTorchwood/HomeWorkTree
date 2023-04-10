namespace HomeWorkTree;

public static class EmployeeManipulator
{
    public static void Traverse(Employee root)
    {
        if (root.LeftEmployee != null)
        {
            Traverse(root.LeftEmployee);
        }
        root.PrintEmployee();
        if (root.RightEmployee != null)
        {
            Traverse(root.RightEmployee);
        }
    }
    public static void AddEmployee(Employee root, Employee employeeToAdd)
    {
        if (employeeToAdd.Salary < root.Salary)
        {
            if (root.LeftEmployee != null)
            {
                AddEmployee(root.LeftEmployee, employeeToAdd);
            }
            else
            {
                root.LeftEmployee = employeeToAdd;
            }
        }
        else
        {
            if (root.RightEmployee != null)
            {
                AddEmployee(root.RightEmployee, employeeToAdd);
            }
            else
            {
                root.RightEmployee = employeeToAdd;
            }
        }
    }

    public static Employee FindEmployee(Employee root, int salary)
    {
        if (salary < root.Salary)
        {
            if (root.LeftEmployee != null)
            {
                return FindEmployee(root.LeftEmployee, salary);
            }

            return null;
        }
        if (salary > root.Salary)
        {
            if (root.RightEmployee != null)
            {
                return FindEmployee(root.RightEmployee, salary);
            }

            return null;
        }

        return (root);
    }
}