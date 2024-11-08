using System;                          // Importiert die System-Bibliothek, die grundlegende Funktionen wie Console-Operationen enthält.
using System.Linq;                     // Importiert die System.Linq-Bibliothek, um erweiterte Operationen wie String-Operationen (z.B. Reverse) zu ermöglichen.

class Program                          // Definiert die Klasse `Program`, die das Hauptprogramm enthält.
{
    static void Main()                 // Die `Main`-Methode ist der Startpunkt des Programms.
    {
        WähleMathematischeOperation(); // Ruft die Methode auf, um eine mathematische Operation auszuwählen und auszuführen.
        Console.WriteLine("\nJetzt folgen die String-Operationen:"); // Informiert den Benutzer, dass nun String-Operationen folgen.
        StringOperationen();           // Ruft die Methode auf, um String-Operationen durchzuführen.
    }

    static void WähleMathematischeOperation() // Definiert die Methode, die den Benutzer auffordert, eine mathematische Operation zu wählen.
    {
        Console.WriteLine("Wählen Sie eine mathematische Operation:"); // Zeigt dem Benutzer den Text zur Auswahl an.
        Console.WriteLine("1... Multiplizieren");
        Console.WriteLine("2... Dividieren");
        Console.WriteLine("3... Addieren");
        Console.WriteLine("4... Potenzieren");
        Console.WriteLine("5... Wurzelziehen");
        Console.WriteLine("6... Fakultät");
        Console.WriteLine("7... Invertieren");
        
        int auswahl = int.Parse(Console.ReadLine()); // Liest die Benutzereingabe (eine Zahl) und wandelt sie in einen Ganzzahlwert um.

        switch (auswahl)               // Überprüft die Auswahl des Benutzers, um die entsprechende Operation auszuführen.
        {
            case 1:
                BerechneZweiZahlen((a, b) => a * b, "Multiplizieren"); // Falls der Benutzer '1' wählt, wird die Multiplikation durchgeführt.
                break;
            case 2:
                BerechneZweiZahlen((a, b) => a / b, "Dividieren");     // Falls der Benutzer '2' wählt, wird die Division durchgeführt.
                break;
            case 3:
                BerechneZweiZahlen((a, b) => a + b, "Addieren");       // Falls der Benutzer '3' wählt, wird die Addition durchgeführt.
                break;
            case 4:
                BerechneZweiZahlen((a, b) => (int)Math.Pow(a, b), "Potenzieren"); // Falls der Benutzer '4' wählt, wird die Potenzierung durchgeführt.
                break;
            case 5:
                BerechneEineZahl(a => Math.Sqrt(a), "Wurzelziehen");   // Falls der Benutzer '5' wählt, wird die Quadratwurzel berechnet.
                break;
            case 6:
                BerechneEineZahl(Fakultät, "Fakultät");                // Falls der Benutzer '6' wählt, wird die Fakultät berechnet.
                break;
            case 7:
                BerechneEineZahl(a => 1.0 / a, "Invertieren");         // Falls der Benutzer '7' wählt, wird die Invertierung durchgeführt.
                break;
            default:
                Console.WriteLine("Ungültige Auswahl!");               // Falls die Eingabe nicht zwischen 1 und 7 liegt, wird eine Fehlermeldung angezeigt.
                break;
        }
    }

    static void BerechneZweiZahlen(Func<int, int, int> operation, string operationName) // Methode zur Berechnung von zwei Zahlen mit einer Operation.
    {
        Console.WriteLine($"Geben Sie die beiden Zahlen für das {operationName} ein:"); // Fordert den Benutzer auf, zwei Zahlen einzugeben.
        int zahl1 = int.Parse(Console.ReadLine());  // Liest die erste Zahl vom Benutzer ein.
        int zahl2 = int.Parse(Console.ReadLine());  // Liest die zweite Zahl vom Benutzer ein.

        int ergebnis = operation(zahl1, zahl2);     // Führt die Operation (z.B. Multiplikation, Addition) mit den beiden Zahlen aus.
        Console.WriteLine($"Das Ergebnis der {operationName} ist: {ergebnis}"); // Zeigt das Ergebnis der Berechnung an.
    }

    static void BerechneEineZahl(Func<double, double> operation, string operationName) // Methode zur Berechnung einer Zahl mit einer Operation.
    {
        Console.WriteLine($"Geben Sie die Zahl für das {operationName} ein:"); // Fordert den Benutzer auf, eine Zahl einzugeben.
        double zahl = double.Parse(Console.ReadLine()); // Liest die Zahl vom Benutzer ein.

        double ergebnis = operation(zahl);           // Führt die Operation (z.B. Wurzelziehen, Invertieren) mit der Zahl aus.
        Console.WriteLine($"Das Ergebnis der {operationName} ist: {ergebnis}"); // Zeigt das Ergebnis der Berechnung an.
    }

    static double Fakultät(double n)  // Methode zur Berechnung der Fakultät einer Zahl.
    {
        if (n == 0 || n == 1) return 1;  // Wenn die Zahl 0 oder 1 ist, ist die Fakultät 1.
        double ergebnis = 1;             // Initialisiert das Ergebnis mit 1.
        for (int i = 2; i <= n; i++) ergebnis *= i; // Multipliziert alle Zahlen von 2 bis n, um die Fakultät zu berechnen.
        return ergebnis;                 // Gibt das Ergebnis der Fakultät zurück.
    }

    static void StringOperationen()     // Methode zur Durchführung von String-Operationen.
    {
        Console.WriteLine("Geben Sie einen String ein:"); // Fordert den Benutzer auf, einen Text einzugeben.
        string eingabe = Console.ReadLine();  // Liest den eingegebenen Text vom Benutzer ein.

        int vokalAnzahl = ZaehleVokale(eingabe); // Zählt die Anzahl der Vokale im Text.
        Console.WriteLine($"Anzahl der Vokale (a, e, i, o, u): {vokalAnzahl}"); // Zeigt die Anzahl der Vokale an.

        string umgekehrterString = StringUmkehren(eingabe); // Kehrt den Text um (z.B. "Hallo" wird zu "ollaH").
        Console.WriteLine($"Umgekehrter String: {umgekehrterString}"); // Zeigt den umgekehrten Text an.

        Console.WriteLine("Geben Sie einen weiteren String zum Vergleichen ein:"); // Fordert den Benutzer auf, einen zweiten Text einzugeben.
        string andererString = Console.ReadLine(); // Liest den zweiten Text vom Benutzer ein.
        bool sindGleich = VergleicheStrings(eingabe, andererString); // Vergleicht die beiden Texte (unabhängig von Groß-/Kleinschreibung).
        Console.WriteLine($"Sind die Strings gleich? {sindGleich}"); // Gibt an, ob die beiden Texte gleich sind.
    }

    static int ZaehleVokale(string text) // Methode zur Zählung der Vokale (a, e, i, o, u) im Text.
    {
        return text.ToLower().Count(c => "aeiou".Contains(c)); // Wandelt den Text in Kleinbuchstaben um und zählt die Vokale.
    }

    static string StringUmkehren(string text) // Methode, um den Text rückwärts anzuzeigen.
    {
        return new string(text.Reverse().ToArray()); // Kehrt die Reihenfolge der Zeichen im Text um.
    }

    static bool VergleicheStrings(string text1, string text2) // Methode, um zwei Texte zu vergleichen.
    {
        return text1.Trim().Equals(text2.Trim(), StringComparison.OrdinalIgnoreCase); // Entfernt Leerzeichen und vergleicht die Texte unabhängig von Groß-/Kleinschreibung.
    }