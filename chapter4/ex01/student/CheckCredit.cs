using System;
using static System.Console;
using System.Globalization;
class CheckCredit
{
	static void Main()
	{
		// Write your code here
		const double CREDIT_LIMIT = 8000.0;
		string priceString;
		double price;
		Write("Please enter the purchase price: ");
		priceString = ReadLine();
		price = Convert.ToDouble(priceString);
		if (price > CREDIT_LIMIT)
			WriteLine("You have exceeded the credit limit.");
		else
			WriteLine("Approved.");
		
	}
}