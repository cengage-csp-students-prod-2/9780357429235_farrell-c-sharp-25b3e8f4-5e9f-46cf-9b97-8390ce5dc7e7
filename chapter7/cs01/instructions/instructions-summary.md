In Chapter 6, you continued to modify the *GreenvilleRevenue* program. Now,
modify the program so that the major functions appear in the following individual
methods:

> Be sure to use the all methods provided in the *GreenvilleRevenue.cs* file and define the methods without changing their arguments or access specifiers.

* `GetContestantNumber` - This method gets and returns a valid number of contestants and is called twice
once for last year’s number of contestants and once for this year’s value
* `DisplayRelationship` - This method accepts the number of contestants this year and last year and displays one of the three messages that describes the relationship between the two contestant values
* `GetContestantData` - This method fills the array of competitors and their talent codes
* `GetLists` - This method continuously prompts for talent codes and displays contestants with the corresponding talent until a sentinel value is entered

An example of the program is shown below: 

```
Enter number of contestants last year >> 2
Enter number of contestants this year >> 3
Last year's competition had 2 contestants, and this year's has 3 contestants
Revenue expected this year is $75.00
The competition is bigger than ever!
Enter contestant name >> Matt
Talent codes are:
  S   Singing
  D   Dancing
  M   Musical instrument
  O   Other
       Enter talent code >> S
Enter contestant name >> Sarah
Talent codes are:
  S   Singing
  D   Dancing
  M   Musical instrument
  O   Other
       Enter talent code >> D
Enter contestant name >> Bruno
Talent codes are:
  S   Singing
  D   Dancing
  M   Musical instrument
  O   Other
       Enter talent code >> M

The types of talent are:
Singing                   1
Dancing                   1
Musical instrument        1
Other                     0
```

<!--
{
    "CopyExercise": {
        "name": "GreenvilleRevenue.cs",
        "copyTarget": "/chapter6/cs01/student/GreenvilleRevenue.cs",
        "pasteTarget": "/GreenvilleRevenue.cs"
    }
}
-->
> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`

