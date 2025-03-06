using System;
using static System.Console;
using System.Globalization;
class SalesLetter
{
	static void Main()
    {
        WriteLine("From");
        DisplayContactInfo();
        WriteLine("\n______________________________\n");

        WriteLine("Dear Client,");
        WriteLine("We want to provide you good service.");
        WriteLine("Feel free to contact us at any time.\n");

        DisplayContactInfo();
        WriteLine("\n********\n");

        WriteLine("Looking forward to a long relationship.\n");
        DisplayContactInfo();
    }

    static void DisplayContactInfo()
    {
        WriteLine("C# Company");
        WriteLine("Phone: 555-1234   Cell: 555-0912");
        WriteLine("Email: csharpcompany@csharp.com");
        WriteLine("On the Web at www.csharpcompanyforyou.com");
    }
}