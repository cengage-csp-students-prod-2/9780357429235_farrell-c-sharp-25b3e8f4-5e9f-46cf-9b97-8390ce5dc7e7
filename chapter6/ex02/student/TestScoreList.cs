using System;
using static System.Console;
using System.Globalization;
class TestScoreList
{
	static void Main()
	{
		// Write your code here
		const int num_scores = 8;
		int[] scores = new int[num_scores];
		int sum = 0;

		for (int x = 0; x < num_scores; x++)
		{
			Write("Enter your test score for #{0}: ", x);
			scores[x] = Convert.ToInt32(ReadLine());
			sum += scores[x];
		} 

		double mean = (double)sum / num_scores;

		WriteLine("Test scores and the mean:");
		for (int y = 0; y < num_scores; y++)
		{
			int z = scores[y] - (int)mean;
			WriteLine("Test # {0}: {1,5} From mean: {2,5}", y, scores[y], z);
		}
	}
}