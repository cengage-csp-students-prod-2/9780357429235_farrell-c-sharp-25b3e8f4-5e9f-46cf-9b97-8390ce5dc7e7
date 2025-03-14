using System;
using static System.Console;
using System.Globalization;
class IntegerFacts
{
	static void Main()
	{
		int[] numbers = new int[10];
		int actualValues = FillArray(numbers);
		if (actualValues > 0)
		{
			Statistics(numbers, actualValues, out int max, out int min, out int sum, out double avg);
			WriteLine($"The array has {actualValues} values");
			WriteLine($"The highest value is {max}");
			WriteLine($"The lowest value is {min}");
			WriteLine($"The sum of the values is {sum}");
			WriteLine($"The average is {avg}");

			Write("The inputs were ");
			for (int x = 0; x < actualValues; x++)
			{
				Write(numbers[x]);
				if (x < actualValues -1) Write(", ");
			}
			WriteLine(", and 999");
		}
		else
		{
			WriteLine("No valid number was entered.");
		}
	}
	static int FillArray(int[] array)
	{
		int count = 0;
		while (count < array.Length)
		{
			Write($"Enter a number or enter 999 to stop: ");
			string input = ReadLine();
			if (int.TryParse(input, out int number))
			{
				if (number == 999)
				break;
				array[count] = number;
				count++;
			}
			else
			{
				WriteLine("That is a invalid input, please enter a valid input.");
			}
		}
		return count;
	}
	static void Statistics(int [] array, int value, out int max, out int min, out int sum, out double avg)
	{
	{
		if (value == 0)
		{max = min = sum = 0;
		avg = 0;
		return;
		}
	}
	{
		max = array[0];
		min = array[0];
		sum = array[0];
		for (int x = 1; x < value; x++)
		{
			if (array[x] > max) max = array[x];
			if (array[x] < min) min = array[x];
			sum += array[x];
		}
		avg = (double)sum / value;
	}
	}
}