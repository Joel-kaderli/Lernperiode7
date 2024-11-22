
namespace Bibliotheksverwaltung
{
    public class Buch
    {
        public string Titel { get; set; }
        public string Autor { get; set; }
        public string ISBN { get; set; }
        public bool IstAusgeliehen { get; set; }

        public Buch(string titel, string autor, string isbn)
        {
            Titel = titel;
            Autor = autor;
            ISBN = isbn;
            IstAusgeliehen = false;
        }
    }
}

