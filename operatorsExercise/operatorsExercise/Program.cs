using System;

namespace operatorsExercise
{
	class Program
	{
		static void Main(string[] args)
		{
			int a = 17;
			int b = 4;
			int quotent = a / b;
			int remainder = a % b;

			if(a == 17 && b == 4)
			{
				Console.WriteLine($"The answer is {quotent} with a remainder of {remainder}.");


			}
		}
	}
}
