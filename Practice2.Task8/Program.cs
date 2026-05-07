namespace Practice2.Task8;

class Program
{
    static void Main(string[] args)
    {
            double a;
            
            Console.Write("Введи a:" + " ");
            
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                if (a == 0)
                {
                    Console.WriteLine("Don't do it again");
                    
                    Console.Write("Введи a:" + " ");
                    
                    a = Convert.ToInt32(Console.ReadLine());
                }
            }

            if (a > 0 || a < 0)
            {
                
            Console.Write("Введи b:" + " ");
            
            double b = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введи f:" + " ");
            
            double f = Convert.ToInt32(Console.ReadLine());
            
            double dicision = (a + b - f / a) + f * a * a - (a + b);  
            
            Console.WriteLine("Решение:" + " " + dicision);
            }
    }
}