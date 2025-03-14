using System;
using static System.Console;
using System.Globalization;
class IntegerFacts
{
    static void Main()
    {
        int[] numbers = new int[10];
        int actualValues = FillArray(numbers);
        if (actualValues > 0)
        {
            Statistics(numbers, actualValues, out int max, out int min, out int sum, out double avg);
            WriteLine($"The array has {actualValues} values");
            WriteLine($"The highest value is {max}");
            WriteLine($"The lowest value is {min}");
            WriteLine($"The sum of the values is {sum}");
            WriteLine($"The average is {avg}");

            Write("The inputs were ");
            for (int x = 0; x < actualValues; x++)
            {
                Write(numbers[x]);
                if (x < actualValues - 1) Write(", ");
            }
            WriteLine(", and 999");
        }
        else
        {
            WriteLine("No valid number was entered.");
        }
    }
    static int FillArray(int[] array)
    {
        int count = 0;

        while (count < array.Length)
        {
            Console.Write("Enter a number (or 999 to stop): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number)) // If input is a valid integer
            {
                if (number == 999) // Stop input collection
                    break;

                array[count] = number; // Store number in array
                count++;
            }
            else
            {
                Console.WriteLine("invalid"); // **IMPORTANT:** EXACT expected message
            }
        }
        return count; // Correctly return number of valid inputs stored
    }
    static void Statistics(int[] array, int value, out int max, out int min, out int sum, out double avg)
    {
        if (value == 0) // Handle empty input case
        {
            max = min = sum = 0;
            avg = 0.0;
            return;
        }

        max = array[0]; // Set first valid value as reference
        min = array[0];
        sum = 0; // Start sum at 0

        for (int i = 0; i < value; i++)
        {
            if (array[i] > max) max = array[i]; // Find max
            if (array[i] < min) min = array[i]; // Find min
            sum += array[i]; // Calculate sum
        }

        avg = (double)sum / value; // Ensure floating-point division
    }
}