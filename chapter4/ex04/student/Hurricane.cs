using System;
using static System.Console;
using System.Globalization;
class Hurricane
{
	static void Main()
	{
		// Write your code here
		int windSpeed;
		string windSpeedString;
		Write("Enter the wind speed (mph)");
		windSpeedString = ReadLine();
		windSpeed = Convert.ToInt32(windSpeedString);
		if (windSpeed >= 157)
		{
			WriteLine("This is a category 5 hurricane.");
		}
		else if (windSpeed >= 130)
		{
			WriteLine("This is a category 4 hurricane.");
		}
		else if (windSpeed >= 111)
		{
			WriteLine("This is a category 3 hurricane.");
		}
		else if (windSpeed >= 96)
		{
			WriteLine("This is a category 2 hurricane.");
		}
		else if (windSpeed >= 74)
		{
			WriteLine("This is a category 1 hurricane.");
		}
		else
		{
			WriteLine("This is not a hurricane.");
		}
	}
}