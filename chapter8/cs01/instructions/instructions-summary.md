In Chapter 7, you modified the *GreenvilleRevenue* program to include a number
of methods. 

Now, using your code from *Chapter 7 Case Study 1*, modify your program so every data entry statement uses a `TryParse()` method
to ensure that each piece of data is the correct type. 

Any invalid user entries should generate an appropriate message that contains the word **Invalid**, and the user should be required to reenter the data.

An example of the program is shown below: 
```
Enter number of contestants last year >> 1
Enter number of contestants this year >> 2
Last year's competition had 1 contestants, and this year's has 2 contestants
Revenue expected this year is $50.00
The competition is bigger than ever!
Enter contestant name >> Matt
Talent codes are:
  S   Singing
  D   Dancing
  M   Musical instrument
  O   Other
       Enter talent code >> Sarah
Invalid format - entry must be a single character
That is not a valid code
       Enter talent code >> R
That is not a valid code
       Enter talent code >> J
That is not a valid code
       Enter talent code >> S
Enter contestant name >> Sarah
Talent codes are:
  S   Singing
  D   Dancing
  M   Musical instrument
  O   Other
       Enter talent code >> D

The types of talent are:
Singing                   1
Dancing                   1
Musical instrument        0
Other                     0

Enter a talent type or Z to quit >> Z
```

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`

<!--
{
    "CopyExercise": {
        "name": "GreenvilleRevenue.cs",
        "copyTarget": "/chapter7/cs01/student/GreenvilleRevenue.cs",
        "pasteTarget": "/GreenvilleRevenue.cs"
    }
}
-->
