using System;
using static System.Console;
using System.Globalization;
class InchesToCentimetersInteractive
{
    static void Main()
    {
		double inches;
		Write("Please enter the value of inches you wish to convert to centimeters... ");
		string v = ReadLine();
		inches = Convert.ToDouble(v);
        double centimeters = inches * 2.54;
        WriteLine(" {0} inches is {1} centimeters", inches, centimeters);

    }
}