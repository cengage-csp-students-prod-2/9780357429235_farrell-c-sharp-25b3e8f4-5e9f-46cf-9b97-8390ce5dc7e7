Create a program named *PaintingEstimate* whose `Main()` method prompts a user for length and width of a room in feet. Create a method that accepts the values and then computes the cost of painting the room, assuming the room is rectangular and has four full walls and 9-foot ceilings. The price of the job is $6 per square foot. Return the price to the `Main()` method, and display it.

An example of the program is shown below: 
```
Enter length of the room in feet >> 30
Enter width of room in feet >> 16
Cost of job for 30 X 16 foot room is $4,968.00
```

> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`


