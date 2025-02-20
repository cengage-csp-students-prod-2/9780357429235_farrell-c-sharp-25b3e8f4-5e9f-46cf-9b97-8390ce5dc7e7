using System;
using static System.Console;
using System.Globalization;
class EnterUppercaseLetters
{
	static void Main()
	{
		// Write your code here
		char inputCharacter;
		do
		{
			Write("Enter an uppercase letter or enter '!' to quit: ");
			string input = ReadLine();
			if (string.IsNullOrEmpty(input))
			{
				inputCharacter = ' ';
				continue;
			}
			inputCharacter = input [0];
			if (inputCharacter != '!')
			{
				if (char.IsUpper(inputCharacter))
				{
					WriteLine("OK");
				}
				else
				{
					WriteLine("Sorry - that was not an uppercase letter");
				}
			}
		} while(inputCharacter != '!');
	}
}