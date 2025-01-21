In *Chapter 4* , you created an interactive application named *GreenvilleRevenue* that prompts a user for the number of contestants entered in this year’s and last year’s Greenville Idol competition and displays the revenue expected for this year’s competition if each contestant pays a $25 entrance fee. The program also displays one of three appropriate statements specified in the case problem in *Chapter 4*, based on a comparison between the number of contestants this year and last year. 

Using the *GreenvilleRevenue*  program you wrote in *Case Study 1* of *Chapter 4*,  modify the program so that the user must enter a number between **0** and **30**, inclusive, for the number of contestants each year. If the user enters an incorrect number, the program prompts for a valid value.

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
<!--
{
    "CopyExercise": {
        "name": "GreenvilleRevenue.cs",
        "copyTarget": "/chapter4/cs01/student/GreenvilleRevenue.cs",
        "pasteTarget": "/GreenvilleRevenue.cs"
    }
}
-->
