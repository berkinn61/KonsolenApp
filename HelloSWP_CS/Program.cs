using System;
 
class Program
{
    static void Main()
    {
        string input;
 
        while (true)
        {
            Console.WriteLine("Bitte eine Eingabe tätigen (oder 'Beenden' zum Beenden):");
 
            input = Console.ReadLine();
 
            if (input.Equals("Beenden", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Programm wird beendet.");
                break;
            }
 
            Console.WriteLine("Eingegebener Text: " + input);
        }
    }
}
 