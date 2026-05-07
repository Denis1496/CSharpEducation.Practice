namespace Home_worРk2;

class Program
{
    static void Main(string[] args)
    {
        char[] currentPlayer = ['X', 'O'];
        int[] board = new int[3];
        bool victory = false;

        Console.WriteLine("Do you want play now y/n?:");
        string input = Console.ReadLine();

        if (input == "y")
        {
            char[][] matrix = new char[3][];

            matrix[0] = ['1', '2', '3'];
            matrix[1] = ['4', '5', '6'];
            matrix[2] = ['7', '8', '9'];
            
                for (int k = 0; k < 9; k++)
                {
                    Console.Clear();

                    for (int i = 0; i < matrix.Length; i++)
                    {
                        Console.Write("     ");

                        for (int j = 0; j < matrix[i].Length; j++)
                        {
                            Console.Write("|" + matrix[i][j] + " ");
                        }

                        Console.WriteLine("|");
                        Console.WriteLine("     " + "----------");
                    }

                    Console.Write("Move, you chance to win:" + " ");
                    char move = char.Parse(Console.ReadLine());

                    for (int i = 0; i < matrix.Length; i++)
                    {
                        for (int j = 0; j < matrix[i].Length; j++)
                        {

                            if (move == matrix[i][j] && k % 2 == 0)

                                matrix[i][j] = currentPlayer[0];

                            else if (move == matrix[i][j] && k % 2 != 0)

                                matrix[i][j] = currentPlayer[1];
                        }
                    }

                    if (CheckWin(matrix))
                    {

                        Console.Clear();
                        Console.WriteLine($"Player {(k % 2 == 0 ? "X" : "O")} wins!");
                        break;
                    }
                }
        }
                bool CheckWin(char[][] m)
                {
                    for (int i = 0; i < 3; i++)
                        if (m[i][0] == m[i][1] && m[i][1] == m[i][2])
                            return true;
                    
                    for (int j = 0; j < 3; j++)
                        if (m[0][j] == m[1][j] && m[1][j] == m[2][j])
                            return true;
                    
                    if (m[0][0] == m[1][1] && m[1][1] == m[2][2])
                        return true;

                    if (m[0][2] == m[1][1] && m[1][1] == m[2][0])
                        return true;

                    return false;
                }
            }
        }
    


        
    

