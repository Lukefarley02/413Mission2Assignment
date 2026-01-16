using System;

namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.Write("How many dice rolls would you like to simulate? ");


            string input = Console.ReadLine();
            if (!int.TryParse(input, out int numRolls) || numRolls <= 0)
            {
                Console.WriteLine("Please enter a valid positive integer for the number of rolls.");
                return;
            }


            DiceRoller roller = new DiceRoller();
            int [] results = roller.RollDice(numRolls);

            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numRolls}.");
            Console.WriteLine();

            for (int sum = 2; sum <= 12; sum++)
            {
                double percent = (results[sum] / (double)numRolls) * 100.0;

                int stars = (int)Math.Round(percent, MidpointRounding.AwayFromZero);

                Console.Write($"{sum}: ");
                Console.WriteLine(new string('*', stars));
            }
            Console.WriteLine();
            Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");


        }
    }

    }