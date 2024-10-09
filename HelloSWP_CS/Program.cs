using System;
 
class Program
{
    static void Main()///startpunkt des Programmes
    {
        string input;////um die ingabe zu speichern
 
        while (true) ////startet endloseschleife
        {
            Console.WriteLine("Bitte eine Eingabe tätigen (oder 'Beenden' zum Beenden):");
 ////gibt eine nachricht aus den benutzer eine eingabe zu fordern
            input = Console.ReadLine();
 ////liest die eingabe und speichert es in input
            if (input.Equals("Beenden", StringComparison.OrdinalIgnoreCase))
  ///prüft ob der benutzer beenden geschrieben hat. (Gross &kl. wird ignoriert)         
            {
                Console.WriteLine("Programm wird beendet.");

            ///gibt eine nachricht das das programm beendet wird wenn man beenend schreibt
                break;
                //beendet die ssschleife
            }
 
            Console.WriteLine("Eingegebener Text: " + input);
        }////gibt den text aus wenn er etwas anderes
    }
}
 