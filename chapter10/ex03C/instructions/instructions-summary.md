Create a `RushJob` `class` that derives from `Job`. A `RushJob` has a $150.00 premium that is added to the normal price of the job. Override any methods in the parent class as necessary. Write a new application that creates an array of five `RushJobs`. Prompt the user for values for each, and do not allow duplicate job numbers. When five valid `RushJob` objects have been entered, display them all, plus a total of all prices.

An example of the program is shown below:

```c#
Enter job number 1
Enter customer name Bobbi
Enter description Carpet Cleaning
Enter estimated hours 4
Enter job number 2
Enter customer name Sarah
Enter description Flooding
Enter estimated hours 12
Enter job number 3
Enter customer name Taylor
Enter description Flooring
Enter estimated hours 12
Enter job number 4
Enter customer name Sam
Enter description Gardening
Enter estimated hours 6
Enter job number 5
Enter customer name Alex
Enter description Renovations
Enter estimated hours 60

Summary:

RushJob 1 Bobbi Carpet Cleaning 4 hours @$45.00 per hour. Rush job adds 150 premium. Total price is $330.00
RushJob 2 Sarah Flooding 12 hours @$45.00 per hour. Rush job adds 150 premium. Total price is $690.00
RushJob 3 Taylor Flooring 12 hours @$45.00 per hour. Rush job adds 150 premium. Total price is $690.00
RushJob 4 Sam Gardening 6 hours @$45.00 per hour. Rush job adds 150 premium. Total price is $420.00
RushJob 5 Alex Renovations 60 hours @$45.00 per hour. Rush job adds 150 premium. Total price is $2,850.00

Total for all jobs is $4,980.00
```

> In order to prepend the _$_ to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`
