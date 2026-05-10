namespace Practice2.Task9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose height matrix");
        int size = int.Parse(Console.ReadLine());

        char[][] matrix = new char[size][];
        
        Console.WriteLine("Choose symbol of matrix");
        char c = char.Parse(Console.ReadLine());
        Console.Clear();
        
        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = new char[i + 1];
            
            for (int j = 0; j < matrix[i].Length; j++)
            {
                matrix[i][j] = c;
                Console.Write(matrix[i][j]);
            }
            Console.WriteLine();
        } 
    }
}