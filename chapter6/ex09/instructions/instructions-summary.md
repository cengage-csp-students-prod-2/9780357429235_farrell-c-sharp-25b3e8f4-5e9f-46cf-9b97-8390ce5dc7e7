In Chapter 5, you wrote a *HomeSales* application for three salespeople: Danielle, Edward, and Francis. 

Now, using the code you wrote in *Chapter 5, Programming Exercise 5*, modify the program to use arrays to store the salesperson names, allowed initials, and accumulated sales values.

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
