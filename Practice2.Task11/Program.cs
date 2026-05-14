namespace Practice2.Task11;

class Program
{
    static void Main(string[] args)
    { 
        Console.WriteLine("Input String :");
        string str = Console.ReadLine();
        Console.WriteLine("Input char :");
        char symbole = char.Parse(Console.ReadLine());
        int count = 0;
        
        for (int i = 0; i < str.Length; i++)
        { 
            char c = str[i];
            if (symbole == c)
            { 
                count++;
            }
        }
        double percent = 100 * count/str.Length;
        Console.Write(" The % char in str is: ");
        Console.Write(percent);
        Console.WriteLine("%");
    }
}