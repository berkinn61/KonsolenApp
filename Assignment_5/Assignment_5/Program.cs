using System;
using System.Linq; 

class Program
{
    static void Main()
    {
        Console.WriteLine("Geben Sie einen String ein:");
        string eingabe = Console.ReadLine();

        int vokalAnzahl = ZaehleVokale(eingabe);
        Console.WriteLine($"Anzahl der Vokale (a, e, i, o, u): {vokalAnzahl}");

        string umgekehrterString = StringUmkehren(eingabe);
        Console.WriteLine($"Umgekehrter String: {umgekehrterString}");

        Console.WriteLine("Geben Sie einen weiteren String zum Vergleichen ein:");
        string andererString = Console.ReadLine();
        bool sindGleich = VergleicheStrings(eingabe, andererString);
        Console.WriteLine($"Sind die Strings gleich? {sindGleich}");
    }
    static int ZaehleVokale(string text)
    {
        int zaehler = 0;
        string vokale = "aeiou"; 
        foreach (char c in text.ToLower())
        {
            if (vokale.Contains(c))
            {
                zaehler++;
            }
        }

        return zaehler;
    }
    static string StringUmkehren(string text)
    {
        return new string(text.Reverse().ToArray());
    }
    static bool VergleicheStrings(string text1, string text2)
    {
        return text1.Trim().Equals(text2.Trim(), StringComparison.OrdinalIgnoreCase);
    }
}
