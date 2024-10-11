using System;
using System.Linq;

class Program
{
    static void Main()
    {
        WähleMathematischeOperation();
        Console.WriteLine("\nJetzt folgen die String-Operationen:");
        StringOperationen();
    }
    static void WähleMathematischeOperation()
    {
        Console.WriteLine("Wählen Sie eine mathematische Operation:");
        Console.WriteLine("1... Multiplizieren");
        Console.WriteLine("2... Dividieren");
        Console.WriteLine("3... Addieren");
        Console.WriteLine("4... Potenzieren");
        Console.WriteLine("5... Wurzelziehen");
        Console.WriteLine("6... Fakultät");
        Console.WriteLine("7... Invertieren");
        
        int auswahl = int.Parse(Console.ReadLine());

        switch (auswahl)
        {
            case 1:
                BerechneZweiZahlen((a, b) => a * b, "Multiplizieren");
                break;
            case 2:
                BerechneZweiZahlen((a, b) => a / b, "Dividieren");
                break;
            case 3:
                BerechneZweiZahlen((a, b) => a + b, "Addieren");
                break;
            case 4:
                BerechneZweiZahlen((a, b) => (int)Math.Pow(a, b), "Potenzieren");
                break;
            case 5:
                BerechneEineZahl(a => Math.Sqrt(a), "Wurzelziehen");
                break;
            case 6:
                BerechneEineZahl(Fakultät, "Fakultät");
                break;
            case 7:
                BerechneEineZahl(a => 1.0 / a, "Invertieren");
                break;
            default:
                Console.WriteLine("Ungültige Auswahl!");
                break;
        }
    }
    static void BerechneZweiZahlen(Func<int, int, int> operation, string operationName)
    {
        Console.WriteLine($"Geben Sie die beiden Zahlen für das {operationName} ein:");
        int zahl1 = int.Parse(Console.ReadLine());
        int zahl2 = int.Parse(Console.ReadLine());

        int ergebnis = operation(zahl1, zahl2);
        Console.WriteLine($"Das Ergebnis der {operationName} ist: {ergebnis}");
    }
    static void BerechneEineZahl(Func<double, double> operation, string operationName)
    {
        Console.WriteLine($"Geben Sie die Zahl für das {operationName} ein:");
        double zahl = double.Parse(Console.ReadLine());

        double ergebnis = operation(zahl);
        Console.WriteLine($"Das Ergebnis der {operationName} ist: {ergebnis}");
    }
    static double Fakultät(double n)
    {
        if (n == 0 || n == 1) return 1;
        double ergebnis = 1;
        for (int i = 2; i <= n; i++) ergebnis *= i;
        return ergebnis;
    }
    static void StringOperationen()
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
        return text.ToLower().Count(c => "aeiou".Contains(c));
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