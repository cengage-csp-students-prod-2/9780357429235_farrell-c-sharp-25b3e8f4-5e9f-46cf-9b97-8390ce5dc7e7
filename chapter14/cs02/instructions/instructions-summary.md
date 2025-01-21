In *Chapter 11*, you created the most recent version of the `MarshallsRevenue` program, which prompts the user for customer data for scheduled mural painting. Now, using the program you wrote in *Chapter 11*, save all the entered data to a serialization files called `MarshallsExterior.ser` and `MarshallsInterior.ser` . The `.ser` files should be closed when data entry is complete and then reopened and read in, allowing the user to view lists of customer orders for mural types. 

> Note: We have hidden `.ser` files, although you can still read and write to them.

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`


