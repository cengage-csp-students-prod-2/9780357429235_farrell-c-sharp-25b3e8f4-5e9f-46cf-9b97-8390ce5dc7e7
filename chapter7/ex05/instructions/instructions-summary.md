Create an application for a library and name it *FineForOverdueBooks*. The` Main()` method asks the user to input the number of books checked out and the number of days they are overdue. These values must be passed in the same order to a method named `DisplayFine`. The method calculates and displays the library fine, which is 10 cents per book per day for the first seven days a book is overdue, then 20 cents per book per day for each additional day. Example function signature : `public static void DisplayFine(int books, int days)`

The library fine should be displayed in the following format:
```
The fine for 2 book(s) for 3 day(s) is $0.60
```

> The numbers will vary based on the input.

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`


