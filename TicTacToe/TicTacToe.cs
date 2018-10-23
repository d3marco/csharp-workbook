using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                DrawBoard();
                GetInput();


            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }

        public static void GetInput()
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());

            PlaceMark(row, column);

            // playerTurn == "X" ? playerTurn = "O" : playerTurn = "X";
        }

        public static bool PlaceMark(int row, int column)
        {
            if (board[row][column] != " ")
            {
                Console.WriteLine("The row column is already taken");
                return false;
            }

            board[row][column] = playerTurn;

            return true;
        }
        public static bool CheckForWin()
        {
            if (HorizontalWin())
            {
                return true;
            }
            else if (VerticalWin())
            {
                return true;
            }
            else if (DiagonalWin())
            {
                return true;
            }


            return false;

        }


        public static bool CheckForTie()
        {
            // your code goes here

            return false;
        }

        public static bool HorizontalWin()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0) - 1; j++)
                {
                    if (board[i][j] != board[i][j + 1])
                        return false;
                }
            }
            return true;
        }

        public static bool VerticalWin()
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(0) - 1; j++)
                {
                    if (board[j][i] != board[j + 1][i])
                        return false;
                }
            }
            return true;
        }

        public static bool DiagonalWin()
        {
            if (board[0][2] != board[1][1]) return false;
            if (board[1][1] != board[2][0]) return false;
            if (board[0][0] != board[1][1]) return false;
            if (board[1][1] != board[2][2]) return false;

            return true;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
