namespace ConsoleApp20.Models;

public class Student : Human
{
    public int Grade { get; set; }

    public Student(string name, int grade) : base(name)
    {
        Grade = grade;
    }

    public static void AddStudent(List<Student> students)
    {
        Console.Write("Enter student name : ");
        string name = Console.ReadLine();
start:
        Console.Write("Enter student grade : ");
        string grade = Console.ReadLine();
        bool isGrade = int.TryParse(grade, out int gradeResult);
        if (!isGrade)
        {
            Console.WriteLine("Enter correct grade format!");
            goto start;
        }
        Student student = new Student(name, gradeResult);
        students.Add(student);
        Console.WriteLine("Student added!\n");
    }
    public static void SearchStudents(List<Student> students)
    {
top:
        Console.Write("Enter minimum grade : ");
        string minGrade = Console.ReadLine();
        bool isMinGrade = int.TryParse(minGrade, out int resultMin);
        Console.Write("Enter maximum grade : ");
        bool isMaxGrade = int.TryParse(minGrade, out int resultMax);
        string maxGrade = Console.ReadLine();
        if (!isMinGrade || !isMaxGrade)
        {
            Console.WriteLine("Enter correct grade format!");
            goto top;
        }
        else
        {
            foreach (Student student in students.FindAll(stu => stu.Grade > resultMin && stu.Grade < resultMax))
            {
                Console.WriteLine($"Student name : {student.Name}\nStudent grade : {student.Grade}");
            }
            if (students.FindAll(stu => stu.Grade > resultMin && stu.Grade < resultMax).Count == 0) Console.WriteLine("Student not found");
        }
    }
}
