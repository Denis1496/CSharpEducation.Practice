using ClassLibrary2;

namespace Practice4_Task_2;
using Practice4_Task1;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        
        MathHelper math = new MathHelper();
        Person person = new Person(name, age);
        
        Console.WriteLine($"Result Add: {math.Addition(a, b)}");
        Console.WriteLine($"Result Subtract: {math.Subtraction(a, b)}");
        Console.WriteLine($"Result Multiply: {math.Multiplication(a, b)}");
        Console.WriteLine($"Result Divide: {math.Division(a, b)}");
        person.PrintInfo();
    }
    }
