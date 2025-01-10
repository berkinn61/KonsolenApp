using System;
using System.Collections.Generic;
using System.Linq;

namespace _00_Programmiertest2
{
    public class Schule
    {
        public List<Schueler> SchuelerListe { get; set; } = new List<Schueler>();
        public List<Klassenzimmer> KlassenzimmerListe { get; set; } = new List<Klassenzimmer>();

        // Gibt die Gesamtzahl der Schüler an
        public int AnzahlSchueler()
        {
            return SchuelerListe.Count;
        }

        // Gibt die Anzahl männlicher und weiblicher Schüler zurück
        public (int maennlich, int weiblich) AnzahlSchuelerNachGeschlecht()
        {
            var maennlich = SchuelerListe.Count(s => s.Geschlecht == "Männlich");
            var weiblich = SchuelerListe.Count(s => s.Geschlecht == "Weiblich");
            return (maennlich, weiblich);
        }

        // Gibt die Gesamtzahl der Klassenzimmer an
        public int AnzahlKlassenzimmer()
        {
            return KlassenzimmerListe.Count;
        }

        // Berechnet das Durchschnittsalter der Schüler
        public double Durchschnittsalter()
        {
            if (!SchuelerListe.Any()) return 0;
            var heute = DateTime.Today;
            return SchuelerListe.Average(s => (heute - s.Geburtsdatum).TotalDays / 365.25);
        }

        // Gibt alle Klassenzimmer zurück, die Cynap haben
        public List<Klassenzimmer> RaeumeMitCynap()
        {
            return KlassenzimmerListe.Where(r => r.HatCynap).ToList();
        }

        // Gibt die Anzahl der verschiedenen Klassen an der Schule zurück
        public int AnzahlKlassen()
        {
            return SchuelerListe.Select(s => s.Klasse).Distinct().Count();
        }

        // Gibt ein Dictionary zurück, das die Anzahl der Schüler pro Klasse enthält
        public Dictionary<string, int> KlassenMitSchuelerAnzahl()
        {
            return SchuelerListe
                .GroupBy(s => s.Klasse)
                .ToDictionary(g => g.Key, g => g.Count());
        }

        // Berechnet den Frauenanteil in einer bestimmten Klasse (in Prozent)
        public double FrauenanteilInKlasse(string klasse)
        {
            var schuelerInKlasse = SchuelerListe.Where(s => s.Klasse == klasse).ToList();
            if (!schuelerInKlasse.Any()) return 0;

            var frauen = schuelerInKlasse.Count(s => s.Geschlecht == "Weiblich");
            return (double)frauen / schuelerInKlasse.Count * 100;
        }

        // Prüft, ob eine Klasse in einem bestimmten Klassenzimmer unterrichtet werden kann (Anzahl Schüler <= Anzahl Plätze)
        public bool KannKlasseInRaumUnterrichtetWerden(string klasse, string raumnummer)
        {
            var raum = KlassenzimmerListe.FirstOrDefault(r => r.Raumnummer == raumnummer);
            if (raum == null) return false;

            var anzahlSchueler = SchuelerListe.Count(s => s.Klasse == klasse);
            return anzahlSchueler <= raum.Sitzplaetze;
        }
    }
}