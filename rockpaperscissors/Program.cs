// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace rockpaperscissors;
class program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playagain = true;
        String player;
        String computer;
        String ans;
        while(playagain)
        {
            player = "";
            computer = "";
            ans = "";
            while (player != "ROCK" && player != "PAPER" && player != "SCISSORS") { 
            
                Console.Write("Enter ROCK, PAPER, or SCISSORS: ");
                player = Console.ReadLine();
                player = player.ToUpper();
            }

            int randomNum = random.Next(1, 4);
            switch (randomNum)
            {
                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSORS";
                    break;

            }
            Console.WriteLine("Player: " + player);
            Console.WriteLine("Computer: " + computer);

            switch (player)
            {
                case "ROCK":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else 
                    {
                        Console.WriteLine("You win!");
                    }
                    break;
                case "PAPER":
                    if (computer == "PAPER")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (computer == "SCISSORS")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                    }
                    break;
                case "SCISSORS":
                    if (computer == "SCISSORS")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else if (computer == "ROCK")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                    }
                    break;

            }

            Console.Write("Would you like to play again? (Y/N): ");
            ans = Console.ReadLine();
            ans = ans.ToUpper();

            if (ans == "Y" || ans == "y")
            {
                playagain = true;
            }
            else
            {
                playagain = false;
            }
        }
        Console.WriteLine("");
        Console.WriteLine("Thanks for playing!");
        Console.WriteLine("You may now close the application");

        Console.ReadKey();
    }
}

