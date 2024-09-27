using System;

class ZahlEingabe
{
    static void Main()
    {
        string benutzereingabe; 
        int eingegebeneZahl;   

        while (true) 
        {
            Console.WriteLine("Bitte geben Sie eine natürliche Zahl ein (oder 'stop' zum Beenden):");
            benutzereingabe = Console.ReadLine();

            
            if (benutzereingabe.Equals("stop", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Das Programm wird jetzt beendet.");
                break;
            }

           
            if (int.TryParse(benutzereingabe, out eingegebeneZahl) && eingegebeneZahl >= 0)
            {
                Console.WriteLine("Sie haben die Zahl eingegeben: " + eingegebeneZahl);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe! Bitte geben Sie eine gültige natürliche Zahl ein.");
            }
        }
    }
}
