using System;
using static System.Console;
using System.Globalization;
class ArrayDemo
{
	enum Menu
	{
		IN_ORIGINAL_ORDER = 1, REVERSE_ORDER, SPECIFIC_POSITION, QUIT
	}
	static void Main()
	{
		int[] nums = {7, 6, 3, 2, 10, 8, 4, 5, 9, 1};
		// Write your code here
		int options;
		WriteLine("1 - View the list in order from the first to last position in the stored array.");
		WriteLine("2 - View the list in order from the last to first position.");
		WriteLine("3 - Choose a specific position to view.");
		WriteLine("4 - Quit the application.");
		Write("Enter which option you would like to select: ");
		options = Convert.ToInt32(ReadLine());

		switch (options)
		{
			case 1:
				WriteLine("From first to fast:");

				for (int x = 0; x < nums.Length; x++)
				{
					Write(nums[x] + " ");
				}
				WriteLine();
				break;
			case 2:
				WriteLine("From last to first:");

				for (int x = 0; x < nums.Length; x++)
				{
					Write(nums[x] + " ");
				}
				WriteLine();
				break;
			case 3:
				WriteLine("Enter a position (0-9): ");
				int position = Convert.ToInt32(ReadLine());
				if (position >= 0 && position < nums.Length)
				{
					WriteLine("The value at position {0} is {1}.", position, nums[position]);
				}
				else
				{
					WriteLine("This position is not valid. Please enter a number between 0-9.");
				}
				break;
			case 4:
				WriteLine("Closing the application");
				break;
		}

	}
}