using System;
using static System.Console;
using System.Globalization;
class SumFiveInts
{
	static void Main()
	{
		// Write your code here
		int sum = 0;
		WriteLine("Enter 5 whole numbers: ");

		for (int x = 0; x < 5; x++)
		{
			Write($"Enter number {x + 1}: ");
			int number = Convert.ToInt32(ReadLine());
			sum += number;
		}
		WriteLine("The sum of the 5 numbers is {0}.", sum);
	}
}