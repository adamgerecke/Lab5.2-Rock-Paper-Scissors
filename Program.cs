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
            public abstract int GenerateRoshambo();

            public override string ToString()
            {
                return $"{Roshambo}";
            }

        }
        class TheRock : Player
        {
            public override int GenerateRoshambo()
            {
                int alwaysRock = (int)RoshamboTypes.Rock;
               
                return alwaysRock;
            }

        }

        class Mankind : Player
        {
            
            private static Random rand = new Random();

            public override int GenerateRoshambo()
            {
                int rand_RSB = rand.Next(4);

                int rand_type = (rand_RSB)RoshamboTypes;

                return rand_type;
            }

        }

        /*class User : Player
        {

        }*/
        static void Main(string[] args)
        {
            Player p1 = new TheRock();
            
            
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine();
            
            Console.Write("Enter your name:");
            string playerName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Would you like to play against The Rock or Mankind? (R/M):");
            string computerName = Console.ReadLine().ToUpper();

            int rockchoice = p1.GenerateRoshambo();
            var rChoice = (RoshamboTypes)rockchoice;

            if (computerName == "R")
            {
                Console.Write("Rock, Paper, or Scissors? (R/P/S):");
                
                Console.WriteLine(rChoice);
            }

            
        }
    }
}
