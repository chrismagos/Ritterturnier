using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritterturnier
{
    public class Teilnehmerliste
    {
        public List<Teilnehmer> _teilnehmerListe {  get; set; }
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
                    if (teilnehmer._name == t._name)
                    {
                        throw new NameSchonVorhandenException(teilnehmer._name + " ist schon vorhanden.");
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
                s += teilnehmer.toString() + "\n\n";
            }
            return s;
        }
        public void alleMitWaffenart(Waffenart waffenart)
        {
            foreach (Teilnehmer teilnehmer in _teilnehmerListe)
            {
                Ritter ritter = (Ritter)teilnehmer;
                if (waffenart == ritter._waffe._art)
                {
                    Console.WriteLine(teilnehmer.toString());
                }
            }
        }
    }
}