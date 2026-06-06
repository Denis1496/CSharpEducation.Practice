namespace Practice3_Task1;

class Program
{
    static void Main(string[] args)
    {
        Print_Information("Denis",age: 29);
    }
    static void Print_Information(string name, int age)
    {
        Console.WriteLine($"Name: {name}, Age: {age}");
    }
    
}
