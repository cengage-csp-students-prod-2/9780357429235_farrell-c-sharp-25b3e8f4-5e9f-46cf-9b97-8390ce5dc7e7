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

            Console.WriteLine($"\nThe array has {actualValues} values");
            Console.WriteLine($"The highest value is {max}");
            Console.WriteLine($"The lowest value is {min}");
            Console.WriteLine($"The sum of the values is {sum}");
            Console.WriteLine($"The average is {avg}");

            Console.Write("The inputs were: ");
            for (int i = 0; i < actualValues; i++)
            {
                Console.Write(numbers[i]);
                if (i < actualValues - 1) Console.Write(", ");
            }
            Console.WriteLine(", and 999");
        }
        else
        {
            Console.WriteLine("\nNo valid numbers were entered.");
        }
    }

    static int FillArray(int[] array)
    {
        int count = 0;
        while (count < array.Length)
        {
            Console.Write($"Enter a number (or 999 to stop): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number == 999)
                    break;

                array[count] = number;
                count++;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        return count;
    }

    static void Statistics(int[] array, int value, out int max, out int min, out int sum, out double avg)
    {
        max = array[0];
        min = array[0];
        sum = array[0];

        for (int i = 1; i < value; i++)
        {
            if (array[i] > max) max = array[i];
            if (array[i] < min) min = array[i];
            sum += array[i];
        }

        avg = (double)sum / value;
    }
}