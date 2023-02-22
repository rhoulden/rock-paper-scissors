using System;

namespace RockPaperScissorsRemake
{
    internal class Program
    {
        static void Main()
        {
            GameMenu();
        }
        static void GameMenu()
        {
            bool quit = false;
            while (!quit)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Rock, Paper, Scissors!");
                Console.WriteLine("\nPlease enter an option:\n1. Single-Player\n2. Multi-Player\n3. Quit\n");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        SinglePlayer();
                        break;
                    case "2":
                        MultiPlayer();
                        break;
                    case "3":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("\nInvalid Selection. Please try again.\n");
                        break;
                }
            }
        }

        static void SinglePlayer()
        {
            bool replay = true;
            while (replay)
            {
                Random random = new Random();
                int comInput = (random.Next(1, 3));

                Console.WriteLine("\nPlease enter the numerical value of your choice of Rock, Paper, or Scissors:\n1. Rock\n2. Paper\n3. Scissors\n");
                string singleInput = Console.ReadLine();

                if ((Convert.ToString(comInput)) == singleInput)
                {
                    Console.WriteLine("Draw!");
                }
                else if (Convert.ToInt32(singleInput) == 1 && comInput == 2)
                {
                    Console.WriteLine("You lose\nPaper beats Rock");
                }
                else if (Convert.ToInt32(singleInput) == 1 && comInput == 3)
                {
                    Console.WriteLine("You win!\nRock beats Scissors");
                }
                else if (Convert.ToInt32(singleInput) == 2 && comInput == 1)
                {
                    Console.WriteLine("You win!\nPaper beats Rock");
                }
                else if (Convert.ToInt32(singleInput) == 2 && comInput == 3)
                {
                    Console.WriteLine("You lose\nScissors beats Paper");
                }
                else if (Convert.ToInt32(singleInput) == 3 && comInput == 1)
                {
                    Console.WriteLine("You lose\nRock beats Scissors");
                }
                else if (Convert.ToInt32(singleInput) == 3 && comInput == 2)
                {
                    Console.WriteLine("You win!\nScissors beats Paper");
                }
                else
                {
                    Console.WriteLine("Invalid Selection. Please try again.");
                }

                //Replay Option (SinglePlayer)
                Console.WriteLine("\nPlay Again? [Y/N]\n");
                string replayInput = Console.ReadLine().ToUpper();

                if (replayInput == "Y")
                {
                    Console.WriteLine("Starting a new game...\n");
                }
                else if (replayInput == "N")
                {
                    Console.WriteLine("Returning to menu...");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Selection. Please try again.");
                }
            }
        }

        static void MultiPlayer()
        {
            bool replay = true;
            while (replay)
            {
                Console.WriteLine("\nPlayer 1: Please enter the numerical value of your choice of Rock, Paper, or Scissors:\n1. Rock\n2. Paper\n3. Scissors\n");
                char singleInput = Console.ReadKey(true).KeyChar;

                Console.WriteLine("\nPlayer 2: Please enter the numerical value of your choice of Rock, Paper, or Scissors:\n1. Rock\n2. Paper\n3. Scissors\n");
                char multiInput = Console.ReadKey(true).KeyChar;

                if (singleInput == multiInput)
                {
                    Console.WriteLine("Draw!");
                }
                else if (singleInput == '1' && multiInput == '2')
                {
                    Console.WriteLine("Player 2 wins!\nPaper beats Rock");
                }
                else if (singleInput == '1' && multiInput == '3')
                {
                    Console.WriteLine("Player 1 wins!\nRock beats Scissors");
                }
                else if (singleInput == '2' && multiInput == '1')
                {
                    Console.WriteLine("Player 1 wins!\nPaper beats Rock");
                }
                else if (singleInput == '2' && multiInput == '3')
                {
                    Console.WriteLine("Player 2 wins!\nScissors beats Paper");
                }
                else if (singleInput == '3' && multiInput == '1')
                {
                    Console.WriteLine("Player 2 wins!\nRock beats Scissors");
                }
                else if (singleInput == '3' && multiInput == '2')
                {
                    Console.WriteLine("Player 1 wins!\nScissors beats Paper");
                }
                else
                {
                    Console.WriteLine("Invalid Selection. Please try again.");
                }

                //Replay Option (MultiPlayer)
                Console.WriteLine("Play Again? [Y/N]");
                string replayInput = Console.ReadLine().ToUpper();

                if (replayInput == "Y")
                {
                    Console.WriteLine("Starting a new game...");
                }
                else if (replayInput == "N")
                {
                    Console.WriteLine("Returning to menu...");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid Selection. Please try again.");
                }
            }
        }
    }
}