namespace Practice3.Task3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter you a and b");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose you operation: 1-Addition; 2-Subtraction; 3-Multiplication; 4-Division");
        int operation = int.Parse(Console.ReadLine());
        if (operation == 1)
        {
            Console.WriteLine("You addition is" + " " + Calculator.Addition(a, b));
        }

        if (operation == 2)
        {
            Console.WriteLine("You subtraction is" + " " + Calculator.Subtraction(a, b));
        }

        if (operation == 3)
        {
            Console.WriteLine("You multiplication is" + " " + Calculator.Multiplication(a, b));
        }

        if (operation == 4)
        {
            Console.WriteLine("You division is" + " " + Calculator.Division(a, b));
        }
    }
}

class Calculator
{
    public static int Addition(int a, int b)
    {
        return a + b;
    }

    public static int Subtraction(int a, int b)
    {
        return a - b;
    }

    public static int Multiplication(int a, int b)
    {
        return a * b;
    }

    public static int Division(int a, int b)
    {
        return a / b;
    }
}