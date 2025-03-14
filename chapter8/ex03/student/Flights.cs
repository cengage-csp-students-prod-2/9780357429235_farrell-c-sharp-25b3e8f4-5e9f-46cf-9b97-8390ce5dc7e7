using static System.Console;
class Flights
{
   static void Main()
   {
    int[] flightNumbers = { 201, 321, 510, 633 };
    string[] airportCodes = {"AUS", "CRP", "DFW", "HOU" };
    string[] airportNames = {"Austin", "Corpus Christi", "Dallas Fort Worth", "Houston" };
    string[] times = {"0710", "0830", "0915", "1140" };
    
    Write("Please enter flight number or airport code >> ");
    string userInput = ReadLine().Trim().ToUpper();
    string result;

    if (int.TryParse(userInput, out int flightNumber))
    {
      result = GetFlightInfo(flightNumber, flightNumbers, airportCodes, airportNames, times);
    }
    else
    {
      result = GetFlightInfo(userInput, flightNumbers, airportCodes, airportNames, times);
    }
    WriteLine(result);
   }

   public static string GetFlightInfo(int flight, int[] flightNumbers, string[] codes, string[] names, string[] times)
   {
      for (int x = 0; x < flightNumbers.Length; x++)
      {
         if (flightNumbers[x] == flight)
         {
            return $"Flight #{flight} {codes[x]} {names[x]} Scheduled at: {times[x]}";
         }
      }
      return $"Flight #{flight} was not found";
   }

   public static string GetFlightInfo(string code, int[] flightNumbers, string[] codes, string[] names, string[] times)
   {
      for (int x = 0; x <codes.Length; x++)
      {
         if (codes[x] == code)
         {
            return $"Flight #{flightNumbers[x]} {codes[x]} {names[x]} Scheduled at: {times[x]}";
         }
      }
      return $"Flight to {code} was not found";
   }
}