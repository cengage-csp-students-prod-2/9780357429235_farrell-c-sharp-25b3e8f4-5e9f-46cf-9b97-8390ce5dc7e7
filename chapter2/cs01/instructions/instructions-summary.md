In *Chapter 1*, you created two programs to display the motto for the Greenville
Idol competition that is held each summer during the Greenville County Fair.

Now write a program named *GreenvilleRevenue* that prompts a user for the number of contestants entered in last year’s competition and in this year’s competition. 

* Display all the input data.
* Compute and display the revenue expected for this year’s competition if each contestant pays a $25 entrance fee.
* Also display a statement that indicates whether this year’s competition has more contestants than last year’s.

An example of the program is shown below: 
```
Enter number of contestants last year >> 6
Enter number of contestants this year >> 14
Last year's competition had 6 contestants, and this year's has 14 contestants
Revenue expected this year is $350.00
It is True that this year's competition is bigger than last year's.
```

> Use the output structure displayed above in your program's output. 

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`


