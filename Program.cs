using ConsoleApp20.Models;

List<Student> students = new List<Student>();
List<Employee> employees = new List<Employee>();


bool exit = false;
do
{
    Console.WriteLine("Welcome to menu :\n");
    Console.WriteLine("Choose an operation : \n");
    Console.WriteLine("1. Add Student\n");
    Console.WriteLine("2. Add Employee\n");
    Console.WriteLine("3. Search\n");
    Console.WriteLine("4. Exit\n");
    string choice = Console.ReadLine();
    bool isChoice = int.TryParse(choice, out int end);
    switch (end)
    {
        case 1:
            Student.AddStudent(students);
            break;
        case 2:
            Employee.AddEmployee(employees);
            break;
        case 3:
            Console.Clear();
            start:
            Console.WriteLine("1. Search for employees\n");
            Console.WriteLine("2. Search for students\n");
            string searchChoice = Console.ReadLine();
            bool isInt = int.TryParse(searchChoice, out int result);
            if (result == 1) Employee.SeachEmployees(employees);
            else if (result == 2) Student.SearchStudents(students);
            else
            {
                Console.WriteLine("Enter number 1 or 2");
                goto start;
            }
            break;
        case 4:
            exit = true;
            break;
        default:
            Console.WriteLine("Enter number 1-4");
            break;
    }
} while (exit == false);



