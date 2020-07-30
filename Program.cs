﻿using System;

namespace Lab_5._2_Rock_Paper_Scissors
{
    class Program
    {
        enum RoshamboTypes
        {
            Rock,
            Paper,
            Scissors
        }

        abstract class Player
        { 
            public RoshamboTypes Roshambo { get; set; }
            public string playerName { get; set; }
            public abstract RoshamboTypes GenerateRoshambo();
           

            public override string ToString()
            {
                return $"{Roshambo}";
            }

        }
        class TheRock : Player
        {
            public override RoshamboTypes GenerateRoshambo()
            {
               
                return RoshamboTypes.Rock;
            }

        }

        class Mankind : Player
        {
            
            private static Random rand = new Random();

            public override RoshamboTypes GenerateRoshambo()
            {
                int rand_RSB = rand.Next(3);

                var randomChoice = (RoshamboTypes)rand_RSB;

                return randomChoice;
            }

        }

        class User : Player
        {
            public override RoshamboTypes GenerateRoshambo()
            {
                int playerInput = 2;
                Console.Write("Rock, Paper, or Scissors? (R/P/S):");
                string playerString = Console.ReadLine().ToUpper();

                if (playerString == "R" || playerString == "P" || playerString == "S")
                {
                    switch (playerString)
                    {
                        case "R":
                            playerInput = 0;
                            break;
                        case "P":
                            playerInput = 1;
                            break;
                        case "S":
                            playerInput = 2;
                            break;
                        default:
                            Console.WriteLine("That is not a Valid Input. Throwing Scissors.");
                            break;
                    }
                }    
                var playerChoice = (RoshamboTypes)playerInput;

                return playerChoice;
            }
        }
        static void Main(string[] args)
        {

            Player p2 = new User();


            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine();
            
            Console.Write("Enter your name:");
            p2.playerName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Would you like to play against The Rock or Mankind? (R/M):");
            string computerName = Console.ReadLine().ToUpper();

            bool keepPlaying = true;
            if (computerName == "R")
            {
                Player p1 = new TheRock();
                p1.playerName = "The Rock";
                do
                {
                    Console.WriteLine($"{p2.playerName}: {p2.GenerateRoshambo()}"); //User
                    Console.WriteLine($"{p1.playerName}: {p1.GenerateRoshambo()}"); //Computer

                    if ((int)p2.Roshambo == (int)p1.Roshambo)
                    {
                        Console.WriteLine("Draw!");
                    }
                    else
                    {
                        Console.WriteLine("Not a Draw.");
                    }
                    Console.Write("Would you like to keep playing? (y/n):");
                    string userQuit = Console.ReadLine().ToUpper();
                    if (userQuit != "Y")
                    {
                        keepPlaying = false;
                    }
                } while (keepPlaying);
            }
            else if (computerName == "M")
            {
                Player p1 = new Mankind();
                p1.playerName = "Mankind";
                while (keepPlaying)
                {
                    Console.WriteLine($"{p2.playerName}: {p2.GenerateRoshambo()}");
                    Console.WriteLine($"{p1.playerName}: {p1.GenerateRoshambo()}");
                }

            }
            
        }
    }
}
