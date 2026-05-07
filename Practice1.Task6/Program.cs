namespace Task6;

class Program
{
        
        static void Main(string[] args)
    { 
        double a = 6.5; 
        double b = 10.6;
        double c = Math.Sqrt(a * a + b * b);
        double j = Math.Sqrt(c * c - b * b);
        Console.WriteLine(c);
        Console.WriteLine(j);
    }
}