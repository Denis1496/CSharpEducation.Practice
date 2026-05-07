namespace Practice2.Task4;

class Program
{
    static void Main(string[] args)
    {
        string[] words = new string[2];
       
        for (int i = 0; i < 2; i++)
        {
            words[i] = Console.ReadLine();
        }
        for (int i = 0; i < 2; i++)
        {
            Console.Write(words[i] + " ");
        }
        
    }
}