In *Chapter 4*  of your book, you created an interactive application named *MarshallsRevenue* that prompts a user for the number of interior and exterior murals scheduled to be painted during a month and computes the expected revenue for each type of mural. The program also prompts the user for the month number and modifies the pricing based on requirements listed in *Chapter 4*.

Now, modify your program so that the user must enter a month value from **1** through **12**. If the user enters an incorrect number, the program prompts for a valid value. Also, the user must enter a number between **0** and **30** inclusive for the number of murals of each type; otherwise, the program prompts the user again.

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`

