using System;

namespace RockPaperScissors
{
    class Program
    {
        static int computersScore;
        static int playersScore;
        static int scoreToBeat;
        static bool playerwon;
        static void Main(string[] args)
        {
            Random RandomChoice = new Random();
            Console.WriteLine("What do you want to play too?");
            //set the amount of times needed to win
            scoreToBeat = Convert.ToInt32(Console.ReadLine());
            while (0 < 1)
            {
                Console.WriteLine("Rock (1), Paper (2), Scissors (3)");
                int choice = Convert.ToInt32(Console.ReadLine());

                //returns a random interval between 1 and 3
                int computersChoice = RandomChoice.Next(1, 4);
                if (choice == 1 || choice == 2 || choice == 3)
                {
                    Console.Clear();

                    if (choice == 1 && computersChoice == 1)
                    {
                        DisplayScoreBoard();
                        Console.WriteLine("");
                        Console.WriteLine("You Tied!");

                    }
                    else if (choice == 1 && computersChoice == 2)
                    {
                        computersScore++;
                        DisplayScoreBoard();
                        Console.WriteLine("");
                        Console.WriteLine("You Lost!");

                    }
                    else if (choice == 1 && computersChoice == 3)
                    {
                        playersScore++;
                        DisplayScoreBoard();
                        Console.WriteLine("");
                        Console.WriteLine("You Won!");

                    }
                    else if (choice == 2 && computersChoice == 1)
                    {
                        playersScore++;
                        DisplayScoreBoard();
                        Console.WriteLine("");
                        Console.WriteLine("You Won!");
                    }
                    else if (choice == 2 && computersChoice == 2)
                    {
                        DisplayScoreBoard();
                        Console.WriteLine("");
                        Console.WriteLine("You Tied!");
                    }
                    else if (choice == 2 && computersChoice == 3)
                    {
                        computersScore++;
                        DisplayScoreBoard();
                        Console.WriteLine("");
                        Console.WriteLine("You Lost!");
                    }
                    else if (choice == 3 && computersChoice == 1)
                    {
                        computersScore++;
                        DisplayScoreBoard();
                        Console.WriteLine("");
                        Console.WriteLine("You Lost!");
                    }
                    else if (choice == 3 && computersChoice == 2)
                    {
                        playersScore++;
                        DisplayScoreBoard();
                        Console.WriteLine("");
                        Console.WriteLine("You Won!");
                    }
                    else if (choice == 3 && computersChoice == 3)
                    {
                        DisplayScoreBoard();
                        Console.WriteLine("");
                        Console.WriteLine("You Tied!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid answer! Use (1) for Rock, (2) for Paper, or (3) for Scissors");
                }
                if (computersScore == scoreToBeat)
                {
                    playerwon = false;
                    break;
                }
                else if (playersScore == scoreToBeat)
                {
                    playerwon = true;
                    break;
                }
            }
            if (playerwon)
            {
                Console.Clear();
                DisplayScoreBoard();
                Console.WriteLine("");
                Console.WriteLine("Player Wins!");
            }
            else
            {
                Console.Clear();
                DisplayScoreBoard();
                Console.WriteLine("");
                Console.WriteLine("Computer Wins!");
            }
            Console.ReadKey();
        }
            static public void DisplayScoreBoard()
            {

                Console.WriteLine($"____________________________________");
                Console.WriteLine($"| Player's Score | Computer's score |");
                Console.WriteLine($"|________________|__________________|");
                Console.WriteLine($"|                |                  |");
                Console.WriteLine($"|       {playersScore}        |         {computersScore}        |");
                Console.WriteLine($"|________________|__________________|");


            }
    }
}