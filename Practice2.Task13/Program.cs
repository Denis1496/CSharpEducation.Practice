namespace Practice2.Task13;

class Program
{
    static void Main(string[] args)
    {
       int a = int.Parse(Console.ReadLine());
       int b = int.Parse(Console.ReadLine());
       int c = int.Parse(Console.ReadLine());

       if (a == b || a == c || b == c)
       {
           a += 5;
           b += 5;
           c += 5;

           Console.WriteLine(a);
           Console.WriteLine(b);
           Console.WriteLine(c);
       }
       else
       {
           Console.WriteLine("«равных нет»");
       }
        
    }
}