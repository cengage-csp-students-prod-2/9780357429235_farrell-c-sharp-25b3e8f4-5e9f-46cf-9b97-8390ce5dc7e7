In previous chapters, you created applications for the Greenville Idol competition.

Now, modify your version of the *GreenvilleRevenue* program created in *Chapter 5* so that after the user enters the number of contestants in this year’s competition, the user is prompted for the appropriate number of contestant names and a code for each contestant that indicates the type of talent: 
* S for singing
* D for dancing
* M for playing a musical instrument
* O for other. 

Make sure that all entered codes are valid, and if not, re-prompt the user to enter a correct code.  For example, if **Y** is input, output **Y is not a valid code**, and re-prompt the user until a valid code is entered.

After contestant data entry is complete, display a count of each type of talent.  For example, if there were ten singers, four dancers, seven people who play musical instruments, and one in the other category, the output should be:
```
The types of talent are:
Singing              10
Dancing               4
Musical instrument    7
Other                 1
```

Then, continuously prompt the user for a talent code until the user enters a sentinel value (the uppercase character **Z** should be used as the sentinel value). 

With each code entry, display a list of the contestants with that code, or display a message that the code is not valid and re-prompt the user.  For example, if **M** is entered, the output might be:
```
Contestants with talent Musical instrument are:
Michelle
Nick
```
If **U** is entered, the output should be **U is not a valid code**.

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`

<!--
{
    "CopyExercise": {
        "name": "GreenvilleRevenue.cs",
        "copyTarget": "/chapter5/cs01/student/GreenvilleRevenue.cs",
        "pasteTarget": "/GreenvilleRevenue.cs"
    }
}
-->
