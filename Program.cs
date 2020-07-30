using System;

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
                //int alwaysRock = (int)RoshamboTypes.Rock;
               
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
                Console.Write("Rock, Paper, or Scissors? (R/P/S):");
                int playerInput = int.Parse(Console.ReadLine());
                var playerChoice = (RoshamboTypes)playerInput;

                return playerChoice;
            }
        }
        static void Main(string[] args)
        {
            Player p1 = new TheRock();
            Player p2 = new Mankind();
            Player p3 = new User();
            
            
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine();
            
            Console.Write("Enter your name:");
            string playerName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Would you like to play against The Rock or Mankind? (R/M):");
            string computerName = Console.ReadLine().ToUpper();

            //int rockchoice = p1.GenerateRoshambo();
            //string rChoice = (RoshamboTypes)rockchoice;
            p1.GenerateRoshambo();

            if (computerName == "R")
            {
                Console.WriteLine(p3.GenerateRoshambo());
                Console.Write(p1.GenerateRoshambo());

            }
            else if (computerName == "M")
            {
                Console.Write("Rock, Paper, or Scissors? (R/P/S):");

                    Console.WriteLine(p2.GenerateRoshambo());
     
            }
            
        }
    }
}
