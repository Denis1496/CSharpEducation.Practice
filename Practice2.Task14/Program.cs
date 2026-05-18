namespace Practice2.Task14;

class Program
{
    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        int number  = int.Parse(Console.ReadLine());
        PrintArray(Mass(size, number));
        
    }

    static int[] Mass(int size,int number)
    {
        int[] mass = new int[size];
        for (int i = 0; i < mass.Length; i++)
        {
            mass[i] = number; 
        }
        return mass;
    }

    static void PrintArray(int[] mass)
    {
        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < mass.Length; i++)
        {
            Console.Write(mass[i] + " ");
        }
    }
}


