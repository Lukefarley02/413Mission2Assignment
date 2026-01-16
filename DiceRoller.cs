using System;

namespace DiceRoller
{
	public class DiceRoller
	{
		private readonly Random _random = new Random();
		
		public int[] RollDice(int numRolls)
		{
			int[] counts = new int[13];

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
