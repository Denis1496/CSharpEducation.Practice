using MathLibrary;

class Program
{
    static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        
        MathHelper math = new MathHelper();

        Console.WriteLine(math.Addition(a, b));
        }
    }
