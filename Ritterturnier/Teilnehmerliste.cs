using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritterturnier
{
    class Teilnehmerliste
    {
        private List<Teilnehmer> _teilnehmerListe;
        public Teilnehmerliste()
        {
            _teilnehmerListe = new List<Teilnehmer>();
        }
        public void addTeilnehmer(Ritter teilnehmer)
        {
            try
            {
                foreach (Teilnehmer t in _teilnehmerListe)
                {
                    if (teilnehmer.GetName() == t.GetName())
                    {
                        throw new NameSchonVorhandenException("Der eingegebene Name ist schon vorhanden.");
                    }
                }
                _teilnehmerListe.Add(teilnehmer);
            }
            catch (NameSchonVorhandenException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string listeAlleTeilnehmer()
        {
            String s = "";
            foreach (Ritter teilnehmer in _teilnehmerListe)
            {
                s += teilnehmer.toString() + "\n";
            }
            return s;
        }
        public void alleMitWaffenart(Waffenart waffenart)
        {
            foreach (Teilnehmer teilnehmer in _teilnehmerListe)
            {
                if (teilnehmer is Ritter) {
                    Ritter ritter = (Ritter)teilnehmer;
                    if (waffenart == ritter.getWaffe().getArt())
                    {
                        Console.WriteLine(teilnehmer.toString());
                    }
                }
            }
        }
    }
}