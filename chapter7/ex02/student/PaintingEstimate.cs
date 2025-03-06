using System;
using static System.Console;
using System.Globalization;
class PaintingEstimate
{
	static void Main()
	{
        Write("Enter length of the room in feet >> ");
        double length = Convert.ToDouble(Console.ReadLine());
        Write("Enter width of the room in feet >> ");
        double width = Convert.ToDouble(Console.ReadLine());
        double totalCost = CalculatePaintingCost(length, width);
        WriteLine("Cost of job for {0} X {1} foot room is {2}",
            length, width, totalCost.ToString("C", CultureInfo.GetCultureInfo("en-US")));
    }

    static double CalculatePaintingCost(double length, double width)
    {
        const int height = 9; 
        const double pricePerSquareFoot = 6.0;
        double wallArea = 2 * height * (length + width);
        double totalCost = wallArea * pricePerSquareFoot;
        return totalCost;
    }
}