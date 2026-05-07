namespace Practice2.Task5;

class Program
{
    static void Main(string[] args)
    {
        string[] words = new string[2];
        int i = 0;
        while (i < 2) 
        {
            words[i] = Console.ReadLine();
            i++;
        }
        i = 0;
        while (i < 2)
        {
            Console.Write(words[i] + " ");
            i++;
        }
    }
    }