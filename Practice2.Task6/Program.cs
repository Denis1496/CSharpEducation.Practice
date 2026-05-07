namespace Practice2.Task6;

class Program
{
    static void Main(string[] args)
    {
        string[] words = new string[2];
        int i = 0;
        do
        {
            words[i] = Console.ReadLine();
            i++;
        } 
        while (i < 2);

        i = 0;
        do
        {
            Console.Write(words[i] + " ");
            i++;
        } 
        while (i < 2);
    }
}