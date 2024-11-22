
namespace Bibliotheksverwaltung
{
    public class Mitglied
    {
        public string Name { get; set; }
        public int Mitgliedsnummer { get; set; }

        public Mitglied(string name, int mitgliedsnummer)
        {
            Name = name;
            Mitgliedsnummer = mitgliedsnummer;
        }
    }
}
