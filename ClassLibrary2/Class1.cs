namespace ClassLibrary2;

public class Person
{
    string name;
    int age;
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
        
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
    }
   
}