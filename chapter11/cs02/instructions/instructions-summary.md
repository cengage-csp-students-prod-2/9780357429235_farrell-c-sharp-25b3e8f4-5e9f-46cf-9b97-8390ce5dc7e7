Modify your `MarshallsRevenue` program created in the previous chapter so that it performs the following tasks:

*  Modify the program to use exception-handling techniques to ensure valid values for the month, the number of interior murals scheduled, and the number of exterior murals scheduled. In each case, the program continues to prompt the user until valid entries are made.
*  Modify the program to use exception-handling techniques to ensure valid mural codes for the scheduled jobs.
*  After data entry is complete, the program continuously prompts the user for codes and displays associated jobs. Use exception-handling techniques to verify valid codes.

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
