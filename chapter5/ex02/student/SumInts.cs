using System;
using static System.Console;
using System.Globalization;
class SumInts
{
	static void Main()
	{
		// Write your code here
		int sum = 0;
		int input;
		Write("Enter intergers (enter 999 to stop and add the total up):");
		input = Convert.ToInt32(ReadLine());
		while(input != 999)
		{
			sum += input;
			Write("Enter intergers (enter 999 to stop and add the total up):");
			input = Convert.ToInt32(ReadLine());
		}
		WriteLine("The total values entered is " + sum);
	}
}