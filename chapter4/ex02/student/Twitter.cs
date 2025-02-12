using System;
using static System.Console;
using System.Globalization;
class Twitter
{
	static void Main()
	{
		// Write your code here
		const int TEXT_LENGTH = 140;
		Console.Write("Enter your message: ");
		string message = Console.ReadLine();
		if (message.Length > TEXT_LENGTH)
		{
			Console.WriteLine("The message is too long");
		}
		else
		{
			Console.WriteLine("The message is okay");
		}
	}
}