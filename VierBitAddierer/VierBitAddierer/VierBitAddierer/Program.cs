using System;
public class Addierer
{
    public int Negation(int x) => x == 0 ? 1 : 0;
    public int And(int x, int y) => (x == 1 && y == 1) ? 1 : 0;
    public int Or(int x, int y) => (x == 1 || y == 1) ? 1 : 0;

    public void Halbaddieren(int x, int y, out int s, out int c)
    {
        int x1 = Negation(x);
        int y1 = y;
        int x2 = x;
        int y2 = Negation(y);
        int x3 = x;
        int y3 = y;
        int z1 = And(x1, y1);
        int z2 = And(x2, y2);
        c = And(x3, y3);
        s = Or(z1, z2);
    }

    public void Volladdieren(int a0, int b0, int ue, out int s, out int c)
    {
        Halbaddieren(a0, b0, out int s1, out int c1);
        Halbaddieren(s1, ue, out s, out int c2);
        c = Or(c1, c2);
    }

    public string VierBitAddierer(string bin1, string bin2)
    {
        int carry = 0;
        int result = 0;

        for (int i = 0; i < 4; i++)
        {
            int bit1 = bin1[3 - i] - '0';
            int bit2 = bin2[3 - i] - '0';
            Volladdieren(bit1, bit2, carry, out int sum, out int newCarry);
            result |= (sum << i);
            carry = newCarry;
        }

        if (carry == 1)
        {
            result |= (carry << 4);
        }
        return Convert.ToString(result, 2).PadLeft(5, '0');
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Geben Sie die erste 4-Bit-Zahl ein: ");
        string bin1 = Console.ReadLine();
        Console.Write("Geben Sie die zweite 4-Bit-Zahl ein: ");
        string bin2 = Console.ReadLine();

        if (bin1.Length != 4 || bin2.Length != 4 || !IsBinary(bin1) || !IsBinary(bin2))
        {
            Console.WriteLine("Fehler: Die Eingaben müssen genau 4-Bit-Binärzahlen sein!");
            return;
        }

        Addierer addierer = new Addierer();
        string sumBinary = addierer.VierBitAddierer(bin1, bin2);
        Console.WriteLine($"Ergebnis: {sumBinary} (Binär)");
    }

    static bool IsBinary(string input)
    {
        foreach (char c in input)
        {
            if (c != '0' && c != '1') return false;
        }
        return true;
    }
}