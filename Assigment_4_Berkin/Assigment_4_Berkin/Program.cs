using System;
using System.Globalization;

class DatenErkennung
{
    static void Main()
    {
        while (true) 
        {
            string eingabe = LeseBenutzereingabe("Geben Sie eine Zahl, ein Datum, true/false oder 'stop' zum Beenden ein:");
            
            if (EingabeBeenden(eingabe)) break;
          

            BestimmeDatentyp(eingabe);
        }

        int zahl = LeseNatuerlicheZahl(); 
        int operation = LeseMathematischeOperation();

        FuehreOperationAus(zahl, operation); 
    }

    static string LeseBenutzereingabe(string nachricht) 
    {
        Console.WriteLine(nachricht);
        return Console.ReadLine();
    }

    static bool EingabeBeenden(string eingabe) 
    {
        if (eingabe.Equals("stop", StringComparison.OrdinalIgnoreCase)) 
        {
            Console.WriteLine("Programm  wird beendet.");
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
        else if (double.TryParse(eingabe, NumberStyles.Float, CultureInfo.InvariantCulture, out double doubleWert)
        {
            Console.WriteLine($"Eingabe ist vom Typ Double: {doubleWert}"); 
        }
        else if (DateTime.TryParse(eingabe, out DateTime datumWert))
        {
        {
            Console.WriteLine($"Eingabe ist vom Typ Datum: {datumWert.ToString("d", CultureInfo.CreateSpecificCulture("de-DE"))}");
        }
        else
        {
            Console.WriteLine("Ungültige Eingabe! Bitte geben Sie eine gültige Zahl, ein Datum oder true/false ein.");
        }
    }

    static int LeseNatuerlicheZahl()
    {
        int zahl;
        do
        {
            string eingabe = LeseBenutzereingabe("Geben Sie eine natürliche Zahl ein:");
        } while (!int.TryParse(eingabe, out zahl) || zahl < 1);
    }

    static int LeseMathematischeOperation()
    {
        int operation; 
        {
            string eingabe = LeseBenutzereingabe("Geben Sie eine Zahl zwischen 1 und 3 ein, um eine mathematische Operation auszuwählen:\n1) Quadrat\n2) Wurzel\n3) Fakultät");
        } while (!int.TryParse(eingabe, out operation) || operation < 1 || operation > 3);
        return operation;
    }

    static void FuehreOperationAus(int zahl, int operation)
    {
        switch (operation)
        {
            case 1:
                Console.WriteLine($"Das Quadrat von {zahl} ist {Math.Pow(zahl, 2)}.");
                break;
            case 2:
                Console.WriteLine($"Die Wurzel von {zahl} ist {Math.Sqrt(zahl)}.");
                break;
            case 3:
                Console.WriteLine($"Die Fakultät von {zahl} ist {Fakultaet(zahl)}.");
                break;
            default:
                Console.WriteLine("Ungültige Eingabe.");
                break;
        }
    }

    static long Fakultet(int n)
    {
        if (n == 0 || n == 1) return 1;
        return n * Fakultet(n - 1);
    }
} 