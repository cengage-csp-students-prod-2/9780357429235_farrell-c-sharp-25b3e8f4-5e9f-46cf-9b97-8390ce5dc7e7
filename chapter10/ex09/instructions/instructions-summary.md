Write a program named `SalespersonDemo` that instantiates objects using classes named `RealEstateSalesperson` and `GirlScout`. Create an interface `ISellable` that has the methods `SalesSpeech()` and `MakeSale()`. Demonstrate that each object can use a `SalesSpeech()` method appropriately. Also, use a `MakeSale()` method two or three times with each object, and display the final contents of each object’s data fields. 

First, create an abstract class named `Salesperson`. Fields include `firstName` and `lastName`; the `Salesperson` constructor requires both these values. Include properties for the fields. Include a method called `GetName` that returns a string that holds the `Salesperson`’s full name—the first and last names separated by a space. Then perform the following tasks:

Create an interface called `ISellable` containing: `SalesSpeech()` and `MakeSale()`

Create two child classes of `Salesperson` and `ISellable`: `RealEstateSalesperson` and `GirlScout`. 

The `RealEstateSalesperson` `class` contains fields for the following:
* `TotalValueSold` - The total value sold in dollars (an `int` initialized to 0)
* `TotalCommissionEarned` - Total commission earned (a `double` initialized to 0)
* `CommissionRate` - The commission rate (a `double` required as the last argument to the class constructor, after first name and last name). 

The `GirlScout` `class` includes a field (`TotalBoxes` of type `int`) to hold the number of boxes of cookies sold, which is initialized to 0. 

**Include properties for every field for both of the above classes.**

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`