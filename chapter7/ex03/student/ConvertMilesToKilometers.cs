using System;
using static System.Console;
using System.Globalization;
class ConvertMilesToKilometers
{
	static void Main()
	{
		Write("Enter a number of miles");
		double miles = Convert.ToDouble(ReadLine());
		double kilometers = ConvertToKilometers(miles);
		WriteLine("{0} miles is {1} kilometers", miles, kilometers);
	}
	static double ConvertToKilometers(double miles)
	{
		const double kilometersPerMile = 1.60934;
		return miles * kilometersPerMile;
	}
}