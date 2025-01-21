Create an application named *SalesTransactionDemo* that declares
several `SalesTransaction` objects and displays their values and their sum.

The `SalesTransaction` class contains the following fields:
* `Name` - The salesperson's name (as a `string`), with public getter and setter
* `salesAmount` - The sales amount ( as a `double`), do not define any getter or setter
* `commission` - The commission (as a `double`), do not define any getter or setter
*  `SalesAmount` - The sales amount ( as a `double`), with public getter and public setter
* `Commission` - The commission (as a `double`), with public getter
* `RATE` - A `readonly` field that stores the commission rate (as a `double`).  Define a `getRate()` accessor method that returns the `RATE`

> Make sure you use the right property when accessing the data! Store your data in `salesAmount` and `commission`, but exposing them using `SalesAmount` and `Commission` respectively. 

Include three constructors for the class. One constructor accepts values for the name, sales amount, and rate, and when the sales value is set, the constructor computes the commission as sales value times commission rate. 

The second constructor accepts a name and sales amount, but sets the commission rate to **0**. 

The third constructor accepts a name and sets all the other fields to **0**. 

An overloaded `+ operator `adds the sales values for two `SalesTransaction` objects and returns a new `SalesTransaction` object.

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
