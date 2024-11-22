
using System;

namespace Bibliotheksverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            Bibliothek bibliothek = new Bibliothek();

          
            Buch buch1 = new Buch("Der Herr der Ringe", "J.R.R. Tolkien", "123456789");
            Buch buch2 = new Buch("Die Verwandlung", "Franz Kafka", "987654321");
            Mitglied mitglied1 = new Mitglied("Max Mustermann", 1);
            Mitglied mitglied2 = new Mitglied("Erika Mustermann", 2);

            bibliothek.BuchHinzufuegen(buch1);
            bibliothek.BuchHinzufuegen(buch2);
            bibliothek.MitgliedHinzufuegen(mitglied1);
            bibliothek.MitgliedHinzufuegen(mitglied2);

       
            bool running = true;
            while (running)
            {
                Console.WriteLine("Willkommen im Bibliothekssystem");
                Console.WriteLine("1. Buch ausleihen");
                Console.WriteLine("2. Buch zurückgeben");
                Console.WriteLine("3. Beenden");
                Console.Write("Wähle eine Option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                       
                        bibliothek.VerfuegbareBuecherAnzeigen();

                        Console.Write("Gib die ISBN des Buches ein, das du ausleihen möchtest: ");
                        string isbnAusleihen = Console.ReadLine();
                        Console.Write("Gib die Mitgliedsnummer ein: ");
                        int mitgliedsnummer = int.Parse(Console.ReadLine());
                        bibliothek.BuchAusleihen(isbnAusleihen, mitgliedsnummer);
                        break;

                    case "2":
                        Console.Write("Gib die ISBN des Buches ein, das du zurückgeben möchtest: ");
                        string isbnZurueckgeben = Console.ReadLine();
                        bibliothek.BuchZurueckgeben(isbnZurueckgeben);
                        break;

                    case "3":
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Ungültige Option.");
                        break;
                }
            }
        }
    }
}

