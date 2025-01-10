using System;
using System.Collections.Generic;

namespace _00_Programmiertest2
{
    public class Klassenzimmer
    {
        public string Raumnummer { get; set; }  // Raumnummer des Klassenzimmers
        public double Flaeche { get; set; }  // Fläche des Klassenzimmers
        public int Sitzplaetze { get; set; }  // Anzahl der Sitzplätze im Raum
        public bool HatCynap { get; set; }  // Gibt es Cynap im Raum?
        public List<Schueler> SchuelerListe { get; set; } = new List<Schueler>();  // Schüler im Klassenzimmer
    }
}