using System;
using static System.Console;
using System.Globalization;
class Auction
{
	static void Main()
	{
		const int MIN = 10;
		Write("Please enter your bid >> ");
		string input = ReadLine();

		if (int.TryParse(input, out int intBid))
		{
			AcceptBid(intBid, MIN);
		}
		else if (double.TryParse(input, out double doubleBid))
		{
			AcceptBid(doubleBid, MIN);
		}
		else
		{
			AcceptBid(input, MIN);
		}
	}

	public static void AcceptBid(int bid, int min)
	{
		if (bid >= min)
			WriteLine("Bid accepted");
		else
			WriteLine("Bid not high enough");
	}

	public static void AcceptBid(double bid, int min)
	{
		if (bid >= min)
			WriteLine("Bid accepted");
		else
			WriteLine("Bid not high enough");
	}

	public static void AcceptBid(string bid, int min)
	{
		if (bid.StartsWith("$") && double.TryParse(bid.Substring(1), out double moneyBid))
		{
			AcceptBid(moneyBid, min);
		}
		else if (bid.EndsWith("dollars", StringComparison.OrdinalIgnoreCase) &&
			double.TryParse(bid.Substring(0, bid.Length - 7), out double wordBid))
		{
			AcceptBid(wordBid, min);
		}
		else
		{
			WriteLine("Bid was not in correct format.");
		}
	}
}