In previous chapters, you have created programs for the Greenville Idol competition.
Now add a `Contestant` class with the following characteristics:
* The `Contestant` class contains public static arrays that hold talent codes and
descriptions. Recall that the talent categories are **Singing**, **Dancing**, **Musical instrument**, and **Other**.  Name these fields `talentCodes` and `talentStrings` respectively.
* The class contains an auto-implemented property `Name` that holds a contestant’s name.
* The class contains fields for a talent code (`talentCode`) and description (`talent`). The `set` accessor for the code assigns a code only if it is valid. Otherwise, it assigns **I** for **Invalid**. The talent description is a read-only property that is assigned a value when the code is set. 

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
<!--
{
    "CopyExercise": {
        "name": "GreenvilleRevenue.cs",
        "copyTarget": "/chapter8/cs01/student/GreenvilleRevenue.cs",
        "pasteTarget": "/GreenvilleRevenue.cs"
    }
}
-->
