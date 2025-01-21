In *Chapter 11*, you created the most recent version of the `GreenvilleRevenue` program, which prompts the user for contestant data for this year’s Greenville Idol competition. Now, save all the entered data to a `Greenville.ser` file that is closed when data entry is complete and then reopened and read in, allowing the user to view lists of contestants with requested talent types. The program should output the name of the contestant, the talent, and the fee. 

> Note: We have hidden `.ser` files, although you can still read and write to them.

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`

<!--
{
    "CopyExercise": {
        "name": "GreenvilleRevenue.cs",
        "copyTarget": "/chapter11/cs01/student/GreenvilleRevenue.cs",
        "pasteTarget": "/GreenvilleRevenue.cs"
    }
}
-->
