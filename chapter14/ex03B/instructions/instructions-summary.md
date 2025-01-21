Write the program `ReadPatientRecords` that reads the file **Patients.txt**  and displays each patient’s data on the screen. 

An example of the program is shown below: 
```
IdNumber  Name                 Balance

222       Anderson           $2,000.00
390       Bell               $2,500.00
488       Carter             $1,000.00
```


> In order to prepend the *$* to currency values, the program will need to use the `CultureInfo.GetCultureInfo` method. In order to do this, include the statement `using System.Globalization;` at the top of your program and format the output statements as follows: `WriteLine("This is an example:  {0}", value.ToString("C", CultureInfo.GetCultureInfo("en-US")));`



