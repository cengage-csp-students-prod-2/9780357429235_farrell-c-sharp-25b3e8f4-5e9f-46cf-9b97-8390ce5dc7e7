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
		WriteLine(" {0} inches is {1} centimeters", inches ,totalCm);

	}
}