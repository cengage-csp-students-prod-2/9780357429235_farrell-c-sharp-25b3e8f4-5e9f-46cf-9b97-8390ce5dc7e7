using System;
using static System.Console;
using System.Globalization;
class Admission
{
	static void Main()
	{
		// Write your code here
		string gradePointString, testScoreString;
		double gradePoint, testScore;
		Write("Please enter your GPA: ");
		gradePointString = ReadLine();
		gradePoint = Convert.ToDouble(gradePointString);
		Write("Please enter your admission test score: ");
		testScoreString = ReadLine();
		testScore = Convert.ToDouble(testScoreString);
		if ((gradePoint >= 3.0 && testScore >= 60) || (gradePoint < 3.0 && testScore >= 80))
			Console.WriteLine("Accept");
			else
			 Console.WriteLine("Reject");
	}
}