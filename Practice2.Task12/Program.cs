namespace Practice2.Task12;

class Program
{
    static void Main(string[] args)
    {
        string a = "hiiii!"; 
        string up = a.ToUpper();
        Console.WriteLine(up);

        string b = "HOHOHO";
        string down = b.ToLower();
        Console.WriteLine(down);
        
        string c = "hellow";
        char [] cc  = c.ToCharArray(); 
        cc[0] = char.ToUpper(cc[0]); 
        string result = new string(cc);
        
            Console.WriteLine(result);
        }
    }                       