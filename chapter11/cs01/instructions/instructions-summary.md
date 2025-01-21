Modify the `GreenvilleRevenue` program created in *Chapter 10, Case Study 1* so that it performs the following tasks:

* The program prompts the user for the number of contestants in this year’s competition; the number must be between 0 and 30. Use exception-handling techniques to ensure a valid value and display the error message: 
```
Number must be between 0 and 30
```
* The program prompts the user for talent codes. Use exception-handling techniques to ensure a valid code and update the displayed message to the following message: 
```
x is not a valid talent code. Assigned as Invalid.
```
where `x` was the invalid code entered into the console. 
* After data entry is complete, the program prompts the user for codes so the user can view lists of appropriate contestants. Use exception-handling techniques for the code verification and display the following message:

```
Enter a talent type or Z to quit >> x
x is not a valid code
```

and for valid codes: 

```
Enter a talent type or Z to quit >> S
Contestants with talent Singing are:
Adult Contestant Mark S   Fee $30.00
```
where `x` was the invalid code entered into the console. 

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`

<!--
{
    "CopyExercise": {
        "name": "GreenvilleRevenue.cs",
        "copyTarget": "/chapter10/cs01/student/GreenvilleRevenue.cs",
        "pasteTarget": "/GreenvilleRevenue.cs"
    }
}
-->
