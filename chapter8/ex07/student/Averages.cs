using System;
using static System.Console;
using System.Globalization;
class Averages
{
	static void Main()
	{
		Average(7, 4);
		Average(7);
		Average(7, 4, 2);
		Average(7, 4, 2, 5, 9, 1, 3);
		Average(new double[] { 1.5, 5.6, 9.4, 3.8 });
	}
	public static void Average(params double[] numbers)
	{
		if (numbers.Length == 0)
		{
			WriteLine("No numbers have been entered");
			return;
		}
		foreach (double num in numbers)
		{
			Write($"{num} ");
		}
		double avg = 0;
		foreach (double num in numbers)
		{
			avg += num;
		}
		avg /= numbers.Length;

		WriteLine($" -- Average is {avg}");
	}
}