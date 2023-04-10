namespace HomeWorkTree;

public class Program
{
    static AppModes mode = AppModes.EnterEmployees;
    public static void Main()
    {
        Employee root = null;
        while (true)
            switch (mode)
            {
                case AppModes.EnterEmployees:
                    root = EnterEmployees(root);
                    break;
                case AppModes.EmployeeSearch:
                    root = FindSalary(root);
                    break;
            }
    }

    private static Employee FindSalary(Employee? root)
    {
        Console.WriteLine("Укажите зарплату, которую вам надо найти:");
        var salary = int.Parse(Console.ReadLine());
        var employee = EmployeeManipulator.FindEmployee(root, salary);
        if (employee == null)
        {
            Console.WriteLine("Такой сотрудник не найден");
        }
        else
        {
            employee.PrintSalary();
        }
        employee = ChooseNextStep(root);
        return employee;
    }

    private static Employee ChooseNextStep(Employee? root)
    {
        Console.WriteLine("Введите 0 для создания нового списка, введите 1 для повторного поиска зарплаты:");
        var input = int.Parse(Console.ReadLine());
        if (input == 0)
        {
            mode = AppModes.EnterEmployees;
            return null;
        }
        else
        {
            mode = AppModes.EmployeeSearch;
            return root;
        }
    }

    private static Employee EnterEmployees(Employee? root)
    {
        while (true)
        {
            var name = SetName();
            if (string.IsNullOrEmpty(name))
            {
                break;
            }
            var salary = SetSalary();

            if (root == null)
            {
                root = new Employee(name, salary);
            }
            else
            {
                EmployeeManipulator.AddEmployee(root, new Employee(name, salary));
            }
        }
        EmployeeManipulator.Traverse(root);
        mode = AppModes.EmployeeSearch;
        return root;
    }



    private static int SetSalary()
    {
        Console.WriteLine("Введите зарплату сотрудника целым числом:");
        return int.Parse(Console.ReadLine());
    }

    private static string SetName()
    {
        Console.WriteLine("Введите имя сотрудника:");
        Console.WriteLine("Для остановки ввода сотрудников введите пустую строку");
        return Console.ReadLine();
    }
}