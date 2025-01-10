using System;

namespace _00_Programmiertest2
{
    class Program
    {
        static void Main(string[] args)
        {
            var schule = new Schule();

            // Beispielhafte Schüler und Klassenzimmer hinzufügen
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Männlich", Geburtsdatum = new DateTime(2008, 1, 18), Klasse = "3aWI" });
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2011, 11, 11), Klasse = "3aWI" });
            schule.KlassenzimmerListe.Add(new Klassenzimmer { Raumnummer = "101", Flaeche = 30.0, Sitzplaetze = 20, HatCynap = true });

            // Ausgabe der verschiedenen Informationen
            Console.WriteLine($"Anzahl Schüler: {schule.AnzahlSchueler()}");
            var geschlechter = schule.AnzahlSchuelerNachGeschlecht();
            Console.WriteLine($"Männlich: {geschlechter.maennlich}, Weiblich: {geschlechter.weiblich}");
            Console.WriteLine($"Anzahl Klassenzimmer: {schule.AnzahlKlassenzimmer()}");
            Console.WriteLine($"Durchschnittsalter: {schule.Durchschnittsalter():F2} Jahre");
            Console.WriteLine($"Räume mit Cynap: {string.Join(", ", schule.RaeumeMitCynap().Select(r => r.Raumnummer))}");
        }
    }
}