using System;

namespace operatorsExercise
{
	class Program
	{
		public static void AreaOfCircle(int radius)
		{
			
		}

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

			//Area of a circle
			Console.WriteLine("What is the radius of your circle?");
			var radius = double.Parse(Console.ReadLine());
			double circleArea = Math.PI * (radius * radius);
			Console.WriteLine($"The area of your circle is {circleArea}");

		}
	}
}
