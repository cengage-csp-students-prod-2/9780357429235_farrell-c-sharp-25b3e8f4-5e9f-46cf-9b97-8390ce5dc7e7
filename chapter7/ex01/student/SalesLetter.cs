using System;
using static System.Console;
using System.Globalization;
class SalesLetter
{
	static void Main()
    {
        Console.WriteLine("From");
        DisplayContactInfo();
        Console.WriteLine("\n______________________________\n");

        Console.WriteLine("Dear Client,");
        Console.WriteLine("We want to provide you good service.");
        Console.WriteLine("Feel free to contact us at any time.\n");

        DisplayContactInfo();
        Console.WriteLine("\n********\n");

        Console.WriteLine("Looking forward to a long relationship.\n");
        DisplayContactInfo();
    }

    static void DisplayContactInfo()
    {
        Console.WriteLine("C# Company");
        Console.WriteLine("Phone: 555-1234   Cell: 555-0912");
        Console.WriteLine("Email: csharpcompany@csharp.com");
        Console.WriteLine("On the Web at www.csharpcompanyforyou.com");
    }
}