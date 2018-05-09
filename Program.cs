using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeDemo
{
    class Program
    {
       
            static void Main(string[] args)
            {
            

            string player = "x";
                string[,] board = new string[3, 3];
                Initialize(board);
                int current = 0;
                
                while (true)
                {

                    Print(board);
                    Console.WriteLine();
                    Console.Write("Please enter row:");
                    int row = int.Parse(Console.ReadLine());
                    Console.Write("please enter col:");
                    int col = int.Parse(Console.ReadLine());
                    Console.Clear();
                    board[row, col] = player;

                    if (player == board[0, 0] && player == board[0, 1] && player == board[0, 2])
                    {

                        Print(board);
                        Console.WriteLine(player + " won  game");
                        Console.ReadKey();
                        break;

                    }
                    if (player == board[0, 0] && player == board[1, 0] && player == board[2, 0])
                    {
                        Print(board);
                        Console.WriteLine(player + "won  game");
                        Console.ReadKey();
                        break;

                    }
                    if (player == board[1, 0] && player == board[1, 1] && player == board[1, 2])
                    {
                        Print(board);
                        Console.WriteLine(player + "won  game");
                        Console.ReadKey();
                        break;

                    }
                    if (player == board[2, 0] && player == board[2, 1] && player == board[2, 2])
                    {
                        Print(board);
                        Console.WriteLine(player + "won  game");
                        Console.ReadKey();
                        break;

                    }
                    if (player == board[0, 0] && player == board[1, 1] && player == board[2, 2])
                    {
                        Print(board);
                        Console.WriteLine(player + "won  game");
                        Console.ReadKey();
                        break;

                    }
                    if (player == board[2, 0] && player == board[1, 1] && player == board[0, 2])
                    {
                        Print(board);
                        Console.WriteLine(player + "won  game");
                        Console.ReadKey();
                        break;

                    }
                    if (player == board[0, 1] && player == board[1, 1] && player == board[2, 1])
                    {
                        Print(board);
                        Console.WriteLine(player + "won  game");
                        Console.ReadKey();
                        break;
                    }
                    if (player == board[0, 2] && player == board[1, 2] && player == board[2, 2])
                    {
                        Print(board);
                        Console.WriteLine(player + "won  game");
                        Console.ReadKey();
                        break;

                    }

                current++;
                    if (current == 9)
                    {
                        Print(board);
                        Console.WriteLine("move");
                        
                    }
                    player = changplayer(player);
                }

            }

            static void Print(string[,] board)
            {
                Console.WriteLine(" 0  |1  |2  |");
              
            for (int row = 0; row < 3; row++)
                {
                    Console.Write(row + "|");
                
                for (int col = 0; col < 3; col++)
                    {
                        Console.Write(board[row, col]);
                        Console.Write(" | ");
                    
                }
                    Console.WriteLine();


                }
            }

            static void Initialize(string[,] board)
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        board[row, col] = " ";

                    }

                }

            }
            static string changplayer(string Cplayer)
            {
                if (Cplayer == "x")
                {
                    return "o";
                }
                else
                {
                    return "x";
                }
            }
       

    }
}
