using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritterturnier
{
    class Knappe : Teilnehmer
    {
        private int _ausbildungsgrad;
        public Knappe(string name, string telefonnummer, int ausbildungsgrad) : base(name, telefonnummer)
        {
            _ausbildungsgrad = ausbildungsgrad;
        }
        public string toString()
        {
            return $"Name: {_name}\nTelefonnummer: {_telefonnummer}\nAusbildungsgrad: {_ausbildungsgrad}\n";
        }
    }
}
