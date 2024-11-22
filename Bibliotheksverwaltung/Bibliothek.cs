// Bibliothek.cs
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bibliotheksverwaltung
{
    public class Bibliothek
    {
        private List<Buch> buecher = new List<Buch>();
        private List<Mitglied> mitglieder = new List<Mitglied>();

        public void BuchHinzufuegen(Buch buch)
        {
            buecher.Add(buch);
        }

        public void BuchEntfernen(Buch buch)
        {
            buecher.Remove(buch);
        }

        public Buch SucheBuchNachISBN(string isbn)
        {
            return buecher.FirstOrDefault(b => b.ISBN == isbn);
        }

        public void MitgliedHinzufuegen(Mitglied mitglied)
        {
            mitglieder.Add(mitglied);
        }

        public void BuchAusleihen(string isbn, int mitgliedsnummer)
        {
            var buch = SucheBuchNachISBN(isbn);
            if (buch != null && !buch.IstAusgeliehen)
            {
                buch.IstAusgeliehen = true;
                Console.WriteLine($"Das Buch '{buch.Titel}' wurde erfolgreich ausgeliehen.");
            }
            else
            {
                Console.WriteLine("Das Buch ist nicht verfügbar.");
            }
        }

        public void BuchZurueckgeben(string isbn)
        {
            var buch = SucheBuchNachISBN(isbn);
            if (buch != null && buch.IstAusgeliehen)
            {
                buch.IstAusgeliehen = false;
                Console.WriteLine($"Das Buch '{buch.Titel}' wurde erfolgreich zurückgegeben.");
            }
            else
            {
                Console.WriteLine("Das Buch wurde nicht ausgeliehen.");
            }

      
            

        }
        public void VerfuegbareBuecherAnzeigen()
        {
            Console.WriteLine("Verfügbare Bücher:");
            foreach (var buch in buecher)
            {
                if (!buch.IstAusgeliehen)
                {
                    Console.WriteLine($"Titel: {buch.Titel}, Autor: {buch.Autor}, ISBN: {buch.ISBN}");
                }
            }
        }
    }
}
