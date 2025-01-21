In *Chapter 1*, you created two programs to display the motto for Marshall’s Murals.

Now write a program named *MarshallsRevenue* that prompts a user for the number of interior and exterior murals scheduled to be painted during the next month. 

Compute the expected revenue for each type of mural. Interior murals cost $500 each, and exterior murals cost $750 each. 

Also display the total expected revenue and a statement that indicates whether more interior murals are scheduled than exterior ones.

An example of the program is shown below: 
```
Enter number of interior murals scheduled >> 3
Enter number of exterior murals scheduled >> 1
3 interior murals are scheduled at $500.00 each for a total of $1,500.00
1 exterior murals are scheduled at $750.00 each for a total of $750.00
Total revenue expected is $2,250.00
It is True that there are more interior murals scheduled than exterior ones.
```

> Use the output structure displayed above in your program's output. 

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
