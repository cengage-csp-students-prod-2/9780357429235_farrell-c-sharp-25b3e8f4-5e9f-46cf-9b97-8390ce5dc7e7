using System;
using static System.Console;
using System.Globalization;
class InchesToCentimeters
{
	static void Main()
	{
		const double cmToInch = 2.54;
		double inches = 3;
		double totalCm = inches * cmToInch;
		WriteLine("The length of {0} inches being converted using {1} centimeters per inch is equal to {2} centimeters", inches, cmToInch ,totalCm);

	}
}