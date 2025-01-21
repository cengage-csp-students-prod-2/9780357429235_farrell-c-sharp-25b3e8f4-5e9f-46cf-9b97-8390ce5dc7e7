In Chapter 7, you modified the *MarshallsRevenue* program to include a number
of methods. 

Now modify your code so every data entry statement to use a `TryParse()` method
to ensure that each piece of data is the correct type. 

Any invalid user entries should generate an appropriate message that includes the phrase **Wrong format**, and the user should be required to reenter the data.

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`

