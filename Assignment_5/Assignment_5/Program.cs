using System;                         // Importiert die System-Bibliothek für grundlegende Funktionen wie Ein- und Ausgabe.
using System.Linq;                    // Importiert die System.Linq-Bibliothek für erweiterte String-Operationen wie Umkehrung.

class Program                         // Definiert die Klasse `Program`, in der alle Methoden des Programms enthalten sind.
{
    static void Main()                // Die `Main`-Methode ist der Startpunkt des Programms.
    {
        Console.WriteLine("Geben Sie einen String ein:");  // Fordert den Benutzer auf, einen Text (String) einzugeben.
        string eingabe = Console.ReadLine();               // Liest den eingegebenen Text (String) vom Benutzer.

        int vokalAnzahl = ZaehleVokale(eingabe);           // Ruft die Methode `ZaehleVokale` auf, um die Anzahl der Vokale im Text zu zählen.
        Console.WriteLine($"Anzahl der Vokale (a, e, i, o, u): {vokalAnzahl}");  // Gibt die Anzahl der gefundenen Vokale aus.

        string umgekehrterString = StringUmkehren(eingabe); // Ruft die Methode `StringUmkehren` auf, um den Text umzukehren.
        Console.WriteLine($"Umgekehrter String: {umgekehrterString}"); // Gibt den umgekehrten Text aus.

        Console.WriteLine("Geben Sie einen weiteren String zum Vergleichen ein:"); // Fordert den Benutzer auf, einen zweiten Text zum Vergleich einzugeben.
        string andererString = Console.ReadLine();        // Liest den zweiten eingegebenen Text vom Benutzer ein.
        bool sindGleich = VergleicheStrings(eingabe, andererString); // Vergleicht die beiden Texte (eingabe und andererString).
        Console.WriteLine($"Sind die Strings gleich? {sindGleich}"); // Gibt aus, ob die beiden Texte gleich sind (True/False).
    }

    static int ZaehleVokale(string text)  // Methode zur Zählung der Vokale im übergebenen Text.
    {
        int zaehler = 0;                 // Initialisiert einen Zähler für die Anzahl der Vokale.
        string vokale = "aeiou";          // Definiert die Vokale, die gezählt werden sollen (a, e, i, o, u).
        foreach (char c in text.ToLower()) // Geht jedes Zeichen im Text durch, wandelt den Text in Kleinbuchstaben um.
        {
            if (vokale.Contains(c))       // Überprüft, ob das Zeichen ein Vokal ist.
            {
                zaehler++;                // Erhöht den Zähler, wenn das Zeichen ein Vokal ist.
            }
        }

        return zaehler;                   // Gibt die Anzahl der Vokale zurück.
    }

    static string StringUmkehren(string text) // Methode, um den übergebenen Text umzukehren.
    {
        return new string(text.Reverse().ToArray()); // Kehrt die Reihenfolge der Zeichen im Text um und gibt sie als neuen String zurück.
    }

    static bool VergleicheStrings(string text1, string text2) // Methode zum Vergleich zweier Texte.
    {
        return text1.Trim().Equals(text2.Trim(), StringComparison.OrdinalIgnoreCase); // Entfernt Leerzeichen am Anfang und Ende beider Texte und vergleicht sie, unabhängig von Groß-/Kleinschreibung.
    }