using System.Collections.Specialized;

namespace ConsoleApp20.Models;

public class Employee : Human
{
    public string Position { get; set; }
    public Employee(string name,string position) : base(name)
    {
        Position=position;
    }
    public static void AddEmployee(List<Employee> employees)
    {
        Console.Write("Enter emoloyee name : ");
        string name = Console.ReadLine();
        Console.Write("Enter employee position : ");
        string position = Console.ReadLine();
        Employee employee = new Employee(name, position);
        employees.Add(employee);
        Console.WriteLine("Employee added!\n");
    }
    public static void SeachEmployees(List<Employee> employees)
    {
        Console.Write("Enter position : ");
        string position = Console.ReadLine();
        foreach (Employee employee in employees.FindAll(emp=>emp.Position == position))
        {
            Console.WriteLine($"Employee name : {employee.Name}\nEmployee position : {employee.Position}");
        }
        if(employees.FindAll(emp => emp.Position == position).Count == 0) Console.WriteLine("Employee not found");
    }
}
