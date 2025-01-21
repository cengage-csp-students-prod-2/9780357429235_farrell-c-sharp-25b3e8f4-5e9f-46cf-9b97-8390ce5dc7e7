In previous chapters, you created applications for Marshall’s Murals. 

Now, modify the version of the *MarshallsRevenue* program created in Chapter 5 so that after mural data entry is complete, the user is prompted for the appropriate number of customer names for both the interior and exterior murals and a code for each that indicates the mural style:
* L for landscape
* S for seascape
* A for abstract
* C for children’s
* O for other

When a code is invalid, re-prompt the user for a valid code continuously.  For example, if **Y** is input, output **Y is not a valid code**, and re-prompt the user until a valid code is entered.

After data entry is complete, display a count of each type of mural.  For example the output should be in the following format with the correct number next to each mural type:
```
The interior murals scheduled are:
Landscape                 1
Seascape                  2
Abstract                  1
Children's                3
Other                     9

The exterior murals scheduled are:
Landscape                 4
Seascape                  0
Abstract                  2
Children's                4
Other                     0
```

Then, continuously prompt the user for a mural style code until the user enters a sentinel value (the uppercase character **Z** should be used as the sentinel value).

With each code entry, display a list of all the customers with that code and whether their mural is interior or exterior. If the requested code is invalid, display an appropriate message and re-prompt the user.  For example if **L** is input, the output might be:
```
Customers ordering Landscape murals are:
Katie Interior
Jake Exterior
```
If **U** is entered, the output should be **U is not a valid code**.

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
