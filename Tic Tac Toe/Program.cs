using System;
namespace Tic_Tac_Toe
{
    class Program
    {

        static string[] loc = new string[10] { "#", "#", "#", "#", "#", "#", "#", "#", "#", "#" };
        private static bool stop = false;
        static int index = 0;


        static void Main(string[] args)
        {
            while (stop == false)
            {
                int turn = 0;
                index = 0;
                Console.WriteLine("Welcome to the game ");
                Console.WriteLine(" Two player in this game : Player1 & Player 2  !");
                Console.WriteLine("Player 1 is '0' and player two is 'X'\n Player 1 Play first : ");
                sampledesign();
                for (turn = 0; turn < 9; turn++)
                {
                    if (turn % 2 == 0)
                    {
                        Console.WriteLine("its player1 turn .\n choose the position : ");
                        index = int.Parse(Console.ReadLine());
                        check();

                        if (index > 0 && index < 10 && loc[index] != "X")
                        {
                            loc[index] = "0";
                        }
                    }


                    else if (turn % 2 == 1)
                    {
                        Console.WriteLine("its player2 turn .\n choose the position : ");
                        index = int.Parse(Console.ReadLine());
                        check();

                        if (index > 0 && index < 10 && loc[index] != "0")
                        {
                            loc[index] = "X";
                        }
                    }

                    sampledesign();
                    stop = win();
                    
                    if (stop == true)
                    {
                        if (turn % 2 == 0)
                        {
                            Console.WriteLine("Player1 win");
                        }
                        else if (turn % 2 == 1)
                        {
                            Console.WriteLine("Player2 win");
                        }
                        turn = 10;
                        break;
                    }

                }

                if (stop == false && turn == 9)
                {
                    Console.WriteLine("It is a draw!!");
                    
                    int a = int.Parse(Console.ReadLine());
                }
            }
        }
        static void sampledesign()
        {
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", loc[1], loc[2], loc[3]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", loc[4], loc[5], loc[6]);
            Console.WriteLine("-------------------");
            Console.WriteLine("   {0}  |  {1}  |  {2}   ", loc[7], loc[8], loc[9]);
        }
        static bool win()
        {

            if (loc[1] == "O" && loc[2] == "O" && loc[3] == "O")
            {

                return true;

            }
            else if (loc[4] == "O" && loc[5] == "O" && loc[6] == "O")
            {
                return true;
            }
            else if (loc[7] == "O" && loc[8] == "O" && loc[9] == "O")
            {
                return true;
            }

            else if (loc[1] == "O" && loc[5] == "O" && loc[9] == "O")
            {
                return true;
            }
            else if (loc[7] == "O" && loc[5] == "O" && loc[3] == "O")
            {
                return true;
            }

            else if (loc[1] == "O" && loc[4] == "O" && loc[7] == "O")
            {
                return true;
            }
            else if (loc[2] == "O" && loc[5] == "O" && loc[8] == "O")
            {
                return true;
            }
            else if (loc[3] == "O" && loc[6] == "O" && loc[9] == "O")
            {
                return true;
            }

            if (loc[1] == "X" && loc[2] == "X" && loc[3] == "X")
            {
                return true;
            }
            else if (loc[4] == "X" && loc[5] == "X" && loc[6] == "X")
            {
                return true;
            }
            else if (loc[7] == "X" && loc[8] == "X" && loc[9] == "X")
            {
                return true;
            }

            else if (loc[1] == "X" && loc[5] == "X" && loc[9] == "X")
            {
                return true;
            }
            else if (loc[7] == "X" && loc[5] == "X" && loc[3] == "X")
            {
                return true;
            }

            else if (loc[1] == "X" && loc[4] == "X" && loc[7] == "X")
            {
                return true;
            }
            else if (loc[2] == "X" && loc[5] == "X" && loc[8] == "X")
            {
                return true;
            }
            else if (loc[3] == "X" && loc[6] == "X" && loc[9] == "X")
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void check()
        {

            if (loc[index] != "#")
            {
                Console.WriteLine("This position is already taken. Choose another one !");
                index = int.Parse(Console.ReadLine());
            }

        }
    }
}