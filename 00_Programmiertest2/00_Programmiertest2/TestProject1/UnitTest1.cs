using _00_Programmiertest2;
using NUnit.Framework;
using System;

namespace UnitTest
{
    [TestFixture]
    public class SchuleTests
    {
        [Test]
        public void AnzahlSchueler_SollteRichtigeAnzahlZurueckgeben()
        {
            var schule = new Schule();
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Männlich", Geburtsdatum = new DateTime(2010, 5, 20), Klasse = "3bWi" });
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2011, 8, 15), Klasse = "3bWi" });

            Assert.AreEqual(2, schule.AnzahlSchueler());
        }

        [Test]
        public void AnzahlSchuelerNachGeschlecht_SollteRichtigeWerteZurueckgeben()
        {
            var schule = new Schule();
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Männlich", Geburtsdatum = new DateTime(2010, 5, 20), Klasse = "3bWi" });
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2011, 8, 15), Klasse = "3bWi" });

            var (maennlich, weiblich) = schule.AnzahlSchuelerNachGeschlecht();

            Assert.AreEqual(1, maennlich);
            Assert.AreEqual(1, weiblich);
        }

        [Test]
        public void Durchschnittsalter_SollteRichtigenWertBerechnen()
        {
            var schule = new Schule();
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Männlich", Geburtsdatum = DateTime.Today.AddYears(-10), Klasse = "3bWi" });
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Weiblich", Geburtsdatum = DateTime.Today.AddYears(-15), Klasse = "3bWi" });

            var durchschnittsalter = schule.Durchschnittsalter();

            Assert.AreEqual(12.5, durchschnittsalter, 0.1);
        }

        [Test]
        public void KannKlasseInRaumUnterrichtetWerden_SollteTrueZurueckgebenWennRaumGenugPlaetzeHat()
        {
            var schule = new Schule();
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Männlich", Geburtsdatum = new DateTime(2010, 5, 20), Klasse = "3bWi" });
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2011, 8, 15), Klasse = "3bWi" });
            schule.KlassenzimmerListe.Add(new Klassenzimmer { Raumnummer = "101", Sitzplaetze = 20 });

            var ergebnis = schule.KannKlasseInRaumUnterrichtetWerden("3bWi", "101");

            Assert.IsTrue(ergebnis);
        }

        [Test]
        public void KannKlasseInRaumUnterrichtetWerden_SollteFalseZurueckgebenWennRaumZuKleinIst()
        {
            var schule = new Schule();
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Männlich", Geburtsdatum = new DateTime(2010, 5, 20), Klasse = "3bWi" });
            schule.SchuelerListe.Add(new Schueler { Geschlecht = "Weiblich", Geburtsdatum = new DateTime(2011, 8, 15), Klasse = "3bWi" });
            schule.KlassenzimmerListe.Add(new Klassenzimmer { Raumnummer = "101", Sitzplaetze = 1 });

            var ergebnis = schule.KannKlasseInRaumUnterrichtetWerden("3bWi", "101");

            Assert.IsFalse(ergebnis);
        }
    }
}