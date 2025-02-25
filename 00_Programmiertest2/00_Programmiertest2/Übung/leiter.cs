using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gib den ersten Wert (0 oder 1) ein:");
        int input1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Gib den zweiten Wert (0 oder 1) ein:");
        int input2 = int.Parse(Console.ReadLine());

        (int s, int c) = Halbaddierer(input1, input2);

        Console.WriteLine($"Ergebnis: s = {s}, c = {c}");
    }

    // Funktion für den Halbaddierer
    static (int s, int c) Halbaddierer(int a, int b)
    {
        int s = a ^ b; // XOR für die Summe
        int c = a & b; // UND für den Übertrag

        return (s, c);
    }
}
