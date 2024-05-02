namespace ConsoleApp20.Models;

public class Human
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public byte Age { get; set; }

    public Human(string name)
    {
        Name = name;
    }
}
