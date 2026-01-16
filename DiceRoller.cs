using System;

namespace DiceRoller
{
	public class DiceRoller
	{
		private readonly Random _random = new Random();
		
		public int[] RollDice(int numRolls)
		{
            //Creates an array to hold counts for sums 2 through 12
            int[] counts = new int[13];

            //simulates rolling two six-sided dice numRolls times
            for (int i = 0; i < numRolls; i++)
			{
				int roll1 = _random.Next(1, 7);
				int roll2 = _random.Next(1, 7);
                int sum = roll1 + roll2;

				counts[sum]++;
            }

			return counts;
        }
    }
}
