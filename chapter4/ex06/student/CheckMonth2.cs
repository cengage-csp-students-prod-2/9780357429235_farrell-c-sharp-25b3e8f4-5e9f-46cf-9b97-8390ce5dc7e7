using System;
using static System.Console;
using System.Globalization;
class CheckMonth2
{
    static void Main()
    {
        // Write your code here

        // This gives a # of days for each month
        int[] daysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Console.Write("Enter your birth month (1-12)");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter your birthday (1-31)");
        int day = Convert.ToInt32(Console.ReadLine());

        //This helps keep the months valid
        if (month < 1 || month > 12)
        {
            Console.WriteLine("Invalid date");
        }
        //Checks for leap year
        if (month == 2)
        {
            Console.Write("Enter the year to check for leap year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                daysInMonth[2] = 29;
            }
        }
        if (day < 1 || day > daysInMonth[month])
        {
            Console.WriteLine("Invalid date");
        }
        else
        {
            Console.WriteLine($"{month}/{day} is a valid birthday.");
        }
    }
}