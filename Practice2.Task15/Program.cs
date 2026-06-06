namespace Practice2.Task15;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int size = int.Parse(Console.ReadLine());
        int[] result = Mass_size(size);
        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i] + " ");
        }
        
    }
    
    static int[] Mass_size(int size)
    {
        int[] n = new int[size];
        Console.Write("Fill a massive number: ");
        for (int i = 0; i < size; i++)
        { 
            n[i] = int.Parse(Console.ReadLine());     
        } 
        
        return n;
    }
}