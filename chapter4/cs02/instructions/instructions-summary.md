In *Chapter 2*, you created an interactive application named *MarshallsRevenue*.  The program prompts a user for the number of interior and
exterior murals scheduled to be painted during the next month by Marshall’s Murals.

Next, the programs compute the expected revenue for each type of mural when
interior murals cost $500 each and exterior murals cost $750 each. The application also displays the total expected revenue and a statement that indicates whether more interior murals are scheduled than exterior ones. 

Using the program you wrote in *Case Study 2* of *Chapter 2*, modify the application to accept a numeric value for the month being scheduled and to modify the pricing as follows:
* Because of uncertain weather conditions, exterior murals cannot be painted in December through February, so change the number of exterior murals to 0 for those months.

* Marshall prefers to paint exterior murals in April, May, September, and October. To encourage business, he charges only $699 for an exterior mural during those months. Murals in other months continue to cost $750.

* Marshall prefers to paint interior murals in July and August, so he charges only
$450 for an interior mural during those months. Murals in other months continue
to cost $500.

The three different examples of the program are shown below: 
```
// 1
Enter the month >> 1
Enter number of interior murals scheduled >> 2
Enter number of exterior murals scheduled >> 3
2 interior murals are scheduled for a total of $1,000.00
0 exterior murals are scheduled for a total of $0.00
Total revenue expected is $1,000.00
It is True that there are more interior murals scheduled than exterior ones.

// 2
Enter the month >> 5
Enter number of interior murals scheduled >> 1
Enter number of exterior murals scheduled >> 2
1 interior murals are scheduled for a total of $500.00
2 exterior murals are scheduled for a total of $1,398.00
Total revenue expected is $1,898.00
It is False that there are more interior murals scheduled than exterior ones.

// 3
Enter the month >> 8
Enter number of interior murals scheduled >> 2
Enter number of exterior murals scheduled >> 1
2 interior murals are scheduled for a total of $900.00
1 exterior murals are scheduled for a total of $750.00
Total revenue expected is $1,650.00
It is True that there are more interior murals scheduled than exterior ones.
```

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`