Previously, you created a `Contestant` class for the Greenville Idol competition.
The class includes a contestant’s name, talent code, and talent description. The
competition has become so popular that separate contests with differing entry fees have been established for children, teenagers, and adults. 

Now, modify your program so the `Contestant` class contains the field `Fee` that holds the entry fee for each category, and add `get` and `set` accessors.

Extend the `Contestant` class to create three subclasses: `ChildContestant`,
`TeenContestant`, and `AdultContestant`. Child contestants are 12 years old and
younger, and their entry fee is $15. Teen contestants are between 13 and 17 years old, inclusive, and their entry fee is $20. Adult contestants are 18 years old and older, and their entry fee is $30. 

In each subclass, set the entry fee field to the correct value, and override the `ToString()` method to return a string that includes all the contestant data, including the age category and the entry fee.  For example, the output from `ToString()` should be displayed in the following format:
```
Child Contestant Joeph S   Fee $15.00
Teen Contestant Sara M   Fee $20.00
Adult Contestant Joy D   Fee $30.00
```

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
<!--
{
    "CopyExercise": {
        "name": "GreenvilleRevenue.cs",
        "copyTarget": "/chapter9/cs01/student/GreenvilleRevenue.cs",
        "pasteTarget": "/GreenvilleRevenue.cs"
    }
}
-->
