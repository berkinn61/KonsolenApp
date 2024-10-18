using System;
using System.Globalization;

class DatenErkennung
{
    static void Main()
    {
        while (true) 
        {
            Console.WriteLine("Geben Sie eine Zahl, ein Datum, true/false oder 'stop' zum Beenden ein:"); 
            string eingabe = Console.ReadLine(); 
            if (EingabeBeenden(eingabe)) 
                break;
            BestimmeDatentyp(eingabe);
        }
    }
    static bool EingabeBeenden(string eingabe)
    {
        if (eingabe.Equals("stop", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Programm wird beendet.");
            return true;
        }
        return false;
    }
    static void BestimmeDatentyp(string eingabe)
    {
        if (bool.TryParse(eingabe, out bool boolWert)) 
        {
            Console.WriteLine($"Eingabe ist vom Typ Bool: {boolWert}");
        }
        else if (int.TryParse(eingabe, out int intWert)) 
        {
            Console.WriteLine($"Eingabe ist vom Typ Integer: {intWert}");
        }
        else if (double.TryParse(eingabe, NumberStyles.Float, CultureInfo.InvariantCulture, out double doubleWert))
            Console.WriteLine($"Eingabe ist vom Typ Double: {doubleWert}");
        }
        else if (DateTime.TryParse(eingabe, out DateTime datumWert)) 
        {
            Console.WriteLine($"Eingabe ist vom Typ Datum: {datumWert.ToString("d", CultureInfo.CreateSpecificCulture("de-DE"))}");
        }
        else
        {

            Console.WriteLine("Ungültige Eingabe! Bitte geben Sie eine gültige Zahl, ein Datum oder true/false ein.");
        }
    }
}