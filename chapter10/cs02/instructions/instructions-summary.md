Previously, you created a `Mural` class for Marshall’s Murals. The class holds a
customer’s name, a mural code, and a description. Now, add a field named `Price` to the `Mural` class that holds a price. 

Now, extend the `Mural` class in your code to create subclasses named `InteriorMural` and `ExteriorMural`, and place statements that determine a mural’s price within these classes. (A mural’s price depends on the month, as described in the case problem in *Chapter 9* of your book.) 

The constructor for the subclasses should have one parameter for the month the mural is scheduled.

Also create `ToString()` methods for these subclasses that return a string containing all the pertinent data for a mural.  The string should be returned in the following format (shown for one exterior and one interior mural):
```
Exterior, Seascape mural for Customer: Steve  Price $699.00
Interior, Landscape mural for Customer: Joe  Price $500.00
```

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`

