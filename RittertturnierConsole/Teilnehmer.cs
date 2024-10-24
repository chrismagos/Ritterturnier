using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritterturnier
{
    public class Teilnehmer
    {
        public string _name { get; set; }
        public string _telefonnummer { get; set; }
        public Teilnehmer() { }
        public Teilnehmer(string name, string telefonnummer) {
            _name = name;
            _telefonnummer = telefonnummer;
        }
        public string toString()
        {
            return $"Name: {_name}\t";
        }
    }
}
