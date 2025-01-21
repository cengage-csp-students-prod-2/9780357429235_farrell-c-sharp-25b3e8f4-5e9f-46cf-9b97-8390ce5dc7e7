In previous chapters, you created programs for Marshall’s Murals. Now, add a`Mural` class to your code with the following characteristics:
* The `Mural` class contains public static arrays that hold mural codes and
descriptions. Recall that the mural categories are **Landscape**, **Seascape**, **Abstract**, **Children’s**, and **Other**.  Name these arrays `muralCodes` and `muralTypes` respectively.
* The class contains an auto-implemented property that holds a mural customer’s
name.
* The class contains fields for a mural code (`code`) and description (`muralType`). The `set` accessor for the code assigns a code only if it is valid. Otherwise, it assigns **I** for** Invalid**. The mural description is a read-only property that is assigned a value when the code is set.


> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
